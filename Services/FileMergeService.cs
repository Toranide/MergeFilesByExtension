using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MergeFilesByExtension.Models;

namespace MergeFilesByExtension.Services
{
    public sealed class FileMergeService
    {
        private static readonly HashSet<string> ForbiddenFolders = new HashSet<string>(
            new[] { "bin", "obj", ".vs", ".git" },
            StringComparer.OrdinalIgnoreCase);

        public MergeResult Merge(
            MergeOptions options,
            Action<string> reportStatus,
            Func<bool> cancellationRequested)
        {
            ValidateOptions(options);

            reportStatus = reportStatus ?? delegate { };
            cancellationRequested = cancellationRequested ?? delegate { return false; };

            var result = new MergeResult();
            var outputDirectory = Path.GetFullPath(options.OutputDirectory);
            Directory.CreateDirectory(outputDirectory);

            var outputDirectoryWithSeparator = EnsureTrailingSeparator(outputDirectory);
            var moduleGroups = GetModuleGroups(
                options.RootPath,
                options.BlockList,
                outputDirectoryWithSeparator);

            foreach (var moduleGroup in moduleGroups)
            {
                ThrowIfCancellationRequested(cancellationRequested);

                reportStatus("Scanning module: " + moduleGroup.Key);

                var files = new List<string>();
                var seenFiles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (var moduleDirectory in moduleGroup.OrderBy(
                    directory => directory.FullName,
                    StringComparer.OrdinalIgnoreCase))
                {
                    CollectFiles(
                        moduleDirectory.FullName,
                        options,
                        outputDirectoryWithSeparator,
                        files,
                        seenFiles,
                        result,
                        reportStatus,
                        cancellationRequested);
                }

                var orderedFiles = files
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .OrderBy(path => path, StringComparer.OrdinalIgnoreCase)
                    .ToList();

                if (orderedFiles.Count == 0)
                {
                    continue;
                }

                reportStatus(
                    string.Format(
                        "Writing {0} ({1} file{2})",
                        moduleGroup.Key,
                        orderedFiles.Count,
                        orderedFiles.Count == 1 ? string.Empty : "s"));

                WriteModuleFile(
                    outputDirectory,
                    moduleGroup.Key,
                    options.RootPath,
                    orderedFiles,
                    result,
                    reportStatus,
                    cancellationRequested);

                result.ModulesCreated++;
            }

            return result;
        }

        private static IEnumerable<IGrouping<string, DirectoryInfo>> GetModuleGroups(
            string rootPath,
            ISet<string> blockList,
            string outputDirectoryWithSeparator)
        {
            IEnumerable<DirectoryInfo> directories;

            try
            {
                directories = Directory
                    .EnumerateDirectories(rootPath, "*", SearchOption.TopDirectoryOnly)
                    .Select(path => new DirectoryInfo(path))
                    .Where(directory => !IsForbiddenDirectory(
                        directory,
                        blockList,
                        outputDirectoryWithSeparator))
                    .Where(directory => !directory.Attributes.HasFlag(FileAttributes.ReparsePoint))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new IOException(
                    "Unable to read the project root directory.",
                    ex);
            }

            return directories
                .Select(directory => new
                {
                    Directory = directory,
                    Key = GetModuleKey(directory.Name)
                })
                .Where(item => !string.IsNullOrWhiteSpace(item.Key))
                .GroupBy(
                    item => item.Key,
                    item => item.Directory,
                    StringComparer.OrdinalIgnoreCase)
                .OrderBy(group => group.Key, StringComparer.OrdinalIgnoreCase)
                .ToList();
        }

        private static void CollectFiles(
            string rootDirectory,
            MergeOptions options,
            string outputDirectoryWithSeparator,
            ICollection<string> files,
            ISet<string> seenFiles,
            MergeResult result,
            Action<string> reportStatus,
            Func<bool> cancellationRequested)
        {
            var directories = new Stack<string>();
            directories.Push(rootDirectory);

            while (directories.Count > 0)
            {
                ThrowIfCancellationRequested(cancellationRequested);

                var currentDirectory = directories.Pop();

                if (IsPathInsideDirectory(
                    currentDirectory,
                    outputDirectoryWithSeparator))
                {
                    continue;
                }

                DirectoryInfo directoryInfo;

                try
                {
                    directoryInfo = new DirectoryInfo(currentDirectory);
                }
                catch (Exception ex)
                {
                    result.FilesSkipped++;
                    result.Errors.Add(
                        string.Format(
                            "Could not inspect directory '{0}': {1}",
                            currentDirectory,
                            ex.Message));
                    continue;
                }

                if (IsForbiddenDirectory(
                    directoryInfo,
                    options.BlockList,
                    outputDirectoryWithSeparator))
                {
                    continue;
                }

                if (directoryInfo.Attributes.HasFlag(FileAttributes.ReparsePoint))
                {
                    continue;
                }

                try
                {
                    foreach (var filePath in Directory.EnumerateFiles(
                        currentDirectory,
                        "*",
                        SearchOption.TopDirectoryOnly))
                    {
                        ThrowIfCancellationRequested(cancellationRequested);

                        if (!MatchesFile(filePath, options))
                        {
                            continue;
                        }

                        var fullPath = Path.GetFullPath(filePath);

                        if (IsPathInsideDirectory(
                                fullPath,
                                outputDirectoryWithSeparator) ||
                            !seenFiles.Add(fullPath))
                        {
                            continue;
                        }

                        files.Add(fullPath);
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    result.FilesSkipped++;
                    result.Errors.Add(
                        string.Format(
                            "Access denied for directory '{0}': {1}",
                            currentDirectory,
                            ex.Message));
                }
                catch (IOException ex)
                {
                    result.FilesSkipped++;
                    result.Errors.Add(
                        string.Format(
                            "Could not enumerate files in '{0}': {1}",
                            currentDirectory,
                            ex.Message));
                }

                try
                {
                    foreach (var subDirectory in Directory.EnumerateDirectories(
                        currentDirectory,
                        "*",
                        SearchOption.TopDirectoryOnly))
                    {
                        var subDirectoryInfo = new DirectoryInfo(subDirectory);

                        if (!subDirectoryInfo.Attributes.HasFlag(FileAttributes.ReparsePoint) &&
                            !IsForbiddenDirectory(
                                subDirectoryInfo,
                                options.BlockList,
                                outputDirectoryWithSeparator))
                        {
                            directories.Push(subDirectory);
                        }
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    result.FilesSkipped++;
                    result.Errors.Add(
                        string.Format(
                            "Access denied while reading subdirectories of '{0}': {1}",
                            currentDirectory,
                            ex.Message));
                }
                catch (IOException ex)
                {
                    result.FilesSkipped++;
                    result.Errors.Add(
                        string.Format(
                            "Could not enumerate subdirectories of '{0}': {1}",
                            currentDirectory,
                            ex.Message));
                }
            }
        }

        private static void WriteModuleFile(
            string outputDirectory,
            string moduleKey,
            string rootPath,
            IList<string> files,
            MergeResult result,
            Action<string> reportStatus,
            Func<bool> cancellationRequested)
        {
            var outputPath = Path.Combine(outputDirectory, moduleKey + ".txt");
            var tempPath = outputPath + "." + Guid.NewGuid().ToString("N") + ".tmp";
            var successfulFiles = 0;

            try
            {
                using (var writer = new StreamWriter(
                    tempPath,
                    false,
                    new UTF8Encoding(false)))
                {
                    writer.WriteLine(new string('=', 90));
                    writer.WriteLine("MODULE: " + moduleKey);
                    writer.WriteLine("FILES: " + files.Count);
                    writer.WriteLine(new string('=', 90));
                    writer.WriteLine();

                    foreach (var filePath in files)
                    {
                        ThrowIfCancellationRequested(cancellationRequested);

                        reportStatus(
                            "Reading: " + GetRelativePath(rootPath, filePath));

                        try
                        {
                            var content = ReadTextFile(filePath);

                            writer.WriteLine(
                                ">>> " + GetRelativePath(rootPath, filePath));
                            writer.WriteLine(new string('-', 90));
                            writer.Write(content);

                            if (!content.EndsWith(
                                Environment.NewLine,
                                StringComparison.Ordinal))
                            {
                                writer.WriteLine();
                            }

                            writer.WriteLine(new string('-', 90));
                            writer.WriteLine();

                            successfulFiles++;
                        }
                        catch (UnauthorizedAccessException ex)
                        {
                            result.FilesSkipped++;
                            result.Errors.Add(
                                string.Format(
                                    "Access denied for file '{0}': {1}",
                                    filePath,
                                    ex.Message));
                        }
                        catch (IOException ex)
                        {
                            result.FilesSkipped++;
                            result.Errors.Add(
                                string.Format(
                                    "Could not read file '{0}': {1}",
                                    filePath,
                                    ex.Message));
                        }
                        catch (DecoderFallbackException ex)
                        {
                            result.FilesSkipped++;
                            result.Errors.Add(
                                string.Format(
                                    "Could not decode file '{0}' as text: {1}",
                                    filePath,
                                    ex.Message));
                        }
                    }
                }

                ThrowIfCancellationRequested(cancellationRequested);

                if (File.Exists(outputPath))
                {
                    File.Delete(outputPath);
                }

                File.Move(tempPath, outputPath);
                result.FilesMerged += successfulFiles;
            }
            finally
            {
                if (File.Exists(tempPath))
                {
                    try
                    {
                        File.Delete(tempPath);
                    }
                    catch
                    {
                        // Best effort cleanup.
                    }
                }
            }
        }

        private static bool MatchesFile(string filePath, MergeOptions options)
        {
            var fileName = Path.GetFileName(filePath);
            var fileStem = Path.GetFileNameWithoutExtension(filePath);

            if (options.BlockList.Contains(fileName) ||
                options.BlockList.Contains(fileStem))
            {
                return false;
            }

            var extension = Path.GetExtension(filePath);
            if (string.IsNullOrEmpty(extension))
            {
                return false;
            }

            return options.Extensions.Contains(
                extension.TrimStart('.'),
                StringComparer.OrdinalIgnoreCase);
        }

        private static bool IsForbiddenDirectory(
            DirectoryInfo directory,
            ISet<string> blockList,
            string outputDirectoryWithSeparator)
        {
            return ForbiddenFolders.Contains(directory.Name) ||
                   blockList.Contains(directory.Name) ||
                   IsPathInsideDirectory(
                       directory.FullName,
                       outputDirectoryWithSeparator);
        }

        private static string GetModuleKey(string directoryName)
        {
            if (string.IsNullOrWhiteSpace(directoryName) ||
                directoryName.StartsWith("."))
            {
                return string.Empty;
            }

            var dotIndex = directoryName.IndexOf('.');

            return dotIndex > 0
                ? directoryName.Substring(0, dotIndex)
                : directoryName;
        }

        private static string ReadTextFile(string filePath)
        {
            using (var reader = new StreamReader(
                filePath,
                new UTF8Encoding(false, true),
                true))
            {
                return reader.ReadToEnd();
            }
        }

        private static string GetRelativePath(
            string rootPath,
            string filePath)
        {
            var fullRoot = EnsureTrailingSeparator(
                Path.GetFullPath(rootPath));
            var fullFile = Path.GetFullPath(filePath);

            if (fullFile.StartsWith(
                fullRoot,
                StringComparison.OrdinalIgnoreCase))
            {
                return fullFile.Substring(fullRoot.Length);
            }

            return fullFile;
        }

        private static string EnsureTrailingSeparator(string path)
        {
            var separator = Path.DirectorySeparatorChar.ToString();

            return path.EndsWith(separator, StringComparison.Ordinal)
                ? path
                : path + separator;
        }

        private static bool IsPathInsideDirectory(
            string path,
            string directoryWithSeparator)
        {
            var fullPath = EnsureTrailingSeparator(
                Path.GetFullPath(path));

            return fullPath.StartsWith(
                directoryWithSeparator,
                StringComparison.OrdinalIgnoreCase);
        }

        private static void ValidateOptions(MergeOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            if (string.IsNullOrWhiteSpace(options.RootPath) ||
                !Directory.Exists(options.RootPath))
            {
                throw new DirectoryNotFoundException(
                    "The selected project folder does not exist.");
            }

            if (string.IsNullOrWhiteSpace(options.OutputDirectory))
            {
                throw new ArgumentException(
                    "An output directory is required.");
            }

            if (options.Extensions == null ||
                options.Extensions.Count == 0)
            {
                throw new ArgumentException(
                    "At least one file extension is required.");
            }

            if (options.BlockList == null)
            {
                throw new ArgumentException(
                    "The block list cannot be null.");
            }
        }

        private static void ThrowIfCancellationRequested(
            Func<bool> cancellationRequested)
        {
            if (cancellationRequested())
            {
                throw new OperationCanceledException();
            }
        }
    }
}
