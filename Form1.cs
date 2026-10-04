using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MergeFilesByExtension
{
    public partial class Form1 : Form
    {
        private readonly string[] forbiddenFolders = { "bin", "obj", ".vs", ".git" };

        public Form1()
        {
            InitializeComponent();
            txtExtension.Text = "cs,cshtml";
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    if (!lstFolders.Items.Contains(fbd.SelectedPath))
                    {
                        lstFolders.Items.Clear();
                        lstFolders.Items.Add(fbd.SelectedPath);
                    }
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (lstFolders.Items.Count == 0)
            {
                MessageBox.Show("لطفا پوشه اصلی پروژه را انتخاب کنید.");
                return;
            }

            string rootPath = lstFolders.Items[0].ToString();

            List<string> moduleKeys;
            try
            {
                moduleKeys = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly)
                    .Select(path => new DirectoryInfo(path).Name)
                    .Select(name => name.Split('.')[0])
                    .Distinct()
                    .Where(key => !string.IsNullOrEmpty(key)) // <-- ✨ راه حل اینجاست: کلیدهای خالی را نادیده بگیر
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در خواندن پوشه‌ها: " + ex.Message);
                return;
            }

            if (!moduleKeys.Any())
            {
                MessageBox.Show("هیچ ماژولی در پوشه انتخاب شده پیدا نشد. مطمئن شوید ساختار پوشه‌ها صحیح است.");
                return;
            }

            string[] extensions = txtExtension.Text.Split(',')
                .Select(x => x.Trim().ToLower().Replace(".", ""))
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();

            if (extensions.Length == 0)
            {
                MessageBox.Show("حداقل یک پسوند فایل وارد کنید (مثلا: cs,cshtml).");
                return;
            }

            string[] blockList = txtBlockList.Text.Split(',')
                .Select(x => x.Trim().ToLower())
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();

            try
            {
                int filesCreated = 0;
                this.Cursor = Cursors.WaitCursor;

                foreach (string moduleKey in moduleKeys)
                {
                    List<string> filesInModule = new List<string>();
                    var moduleFolders = Directory.GetDirectories(rootPath, $"{moduleKey}*", SearchOption.TopDirectoryOnly);

                    foreach (var moduleFolder in moduleFolders)
                    {
                        FindFilesRecursively(moduleFolder, extensions, blockList, filesInModule);
                    }

                    if (!moduleFolders.Any())
                    {
                        var exactMatchFolder = Path.Combine(rootPath, moduleKey);
                        if (Directory.Exists(exactMatchFolder))
                            FindFilesRecursively(exactMatchFolder, extensions, blockList, filesInModule);
                    }

                    if (filesInModule.Count == 0)
                        continue;

                    string outputPath = Path.Combine(Application.StartupPath, moduleKey + ".txt");
                    using (StreamWriter sw = new StreamWriter(outputPath, false))
                    {
                        sw.WriteLine($"===== فایل‌های ماژول {moduleKey} =====");
                        foreach (var file in filesInModule.Distinct().OrderBy(f => f))
                        {
                            sw.WriteLine(">>> " + file);
                            sw.WriteLine(File.ReadAllText(file));
                            sw.WriteLine();
                        }
                    }
                    filesCreated++;
                }

                this.Cursor = Cursors.Default;
                MessageBox.Show($"{filesCreated} فایل با موفقیت در مسیر برنامه ساخته شد.");
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("خطا: " + ex.Message);
            }
        }

        private void FindFilesRecursively(string currentDirectory, string[] extensions, string[] blockList, List<string> collectedFiles)
        {
            var dirInfo = new DirectoryInfo(currentDirectory);
            string dirName = dirInfo.Name.ToLower();

            if (forbiddenFolders.Contains(dirName) || blockList.Contains(dirName))
            {
                return;
            }

            try
            {
                var filesInCurrentDir = Directory.GetFiles(currentDirectory, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(f => extensions.Contains(Path.GetExtension(f).TrimStart('.').ToLower()))
                    .Where(f => !blockList.Contains(Path.GetFileName(f).ToLower()))
                    .Where(f => !blockList.Contains(Path.GetFileNameWithoutExtension(f).ToLower()));
                collectedFiles.AddRange(filesInCurrentDir);
            }
            catch (UnauthorizedAccessException) { /* Ignore */ }

            try
            {
                foreach (var subDirectory in Directory.GetDirectories(currentDirectory))
                {
                    FindFilesRecursively(subDirectory, extensions, blockList, collectedFiles);
                }
            }
            catch (UnauthorizedAccessException) { /* Ignore */ }
        }

    }
}