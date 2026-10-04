using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MergeFilesByExtension.Models;
using MergeFilesByExtension.Services;

namespace MergeFilesByExtension
{
    public partial class Form1 : Form
    {
        private readonly FileMergeService _mergeService =
            new FileMergeService();

        private readonly BackgroundWorker _worker =
            new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();

            txtExtension.Text = "cs,cshtml";
            txtOutputFolder.Text = GetDefaultOutputDirectory();

            _worker.WorkerReportsProgress = true;
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += Worker_DoWork;
            _worker.ProgressChanged += Worker_ProgressChanged;
            _worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            SetProcessingState(false);
            lblStatus.Text = "Ready";
        }

        private void btnBrowseProject_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description =
                    "Select the root folder of your project";

                if (!string.IsNullOrWhiteSpace(txtProjectFolder.Text) &&
                    Directory.Exists(txtProjectFolder.Text))
                {
                    dialog.SelectedPath = txtProjectFolder.Text;
                }

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    txtProjectFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description =
                    "Select the folder where merged files will be created";

                if (!string.IsNullOrWhiteSpace(txtOutputFolder.Text) &&
                    Directory.Exists(txtOutputFolder.Text))
                {
                    dialog.SelectedPath = txtOutputFolder.Text;
                }

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    txtOutputFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var options = BuildOptions();

            if (options == null)
            {
                return;
            }

            SetProcessingState(true);
            btnOpenOutput.Enabled =
                Directory.Exists(options.OutputDirectory);
            progressBar.Style = ProgressBarStyle.Marquee;
            lblStatus.Text = "Preparing...";
            _worker.RunWorkerAsync(options);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_worker.IsBusy)
            {
                _worker.CancelAsync();
                lblStatus.Text = "Cancelling...";
                btnCancel.Enabled = false;
            }
        }

        private void btnOpenOutput_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtOutputFolder.Text))
            {
                MessageBox.Show(
                    this,
                    "The output folder does not exist yet.",
                    "Output Folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            Process.Start(
                "explorer.exe",
                """ + txtOutputFolder.Text + """);
        }

        private void Worker_DoWork(
            object sender,
            DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            var options = (MergeOptions)e.Argument;

            try
            {
                e.Result = _mergeService.Merge(
                    options,
                    status => worker.ReportProgress(0, status),
                    () => worker.CancellationPending);
            }
            catch (OperationCanceledException)
            {
                e.Cancel = true;
            }
        }

        private void Worker_ProgressChanged(
            object sender,
            ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                lblStatus.Text = e.UserState.ToString();
            }
        }

        private void Worker_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Continuous;
            SetProcessingState(false);

            if (e.Cancelled)
            {
                lblStatus.Text = "Cancelled";
                MessageBox.Show(
                    this,
                    "The operation was cancelled.",
                    "Merge Files",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (e.Error != null)
            {
                lblStatus.Text = "Failed";
                MessageBox.Show(
                    this,
                    "The operation failed:" +
                    Environment.NewLine +
                    Environment.NewLine +
                    e.Error.Message,
                    "Merge Files",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var result = (MergeResult)e.Result;

            lblStatus.Text = string.Format(
                "Completed: {0} module file{1}, {2} source file{3} merged.",
                result.ModulesCreated,
                result.ModulesCreated == 1 ? string.Empty : "s",
                result.FilesMerged,
                result.FilesMerged == 1 ? string.Empty : "s");

            btnOpenOutput.Enabled =
                Directory.Exists(txtOutputFolder.Text);

            var summary = string.Format(
                "Created module files: {0}{1}" +
                "Files merged: {2}{3}" +
                "Files skipped: {4}",
                result.ModulesCreated,
                Environment.NewLine,
                result.FilesMerged,
                Environment.NewLine,
                result.FilesSkipped);

            if (result.Errors.Count > 0)
            {
                summary +=
                    Environment.NewLine +
                    Environment.NewLine +
                    "Some items could not be processed:" +
                    Environment.NewLine +
                    string.Join(
                        Environment.NewLine,
                        result.Errors.Take(10));

                if (result.Errors.Count > 10)
                {
                    summary += Environment.NewLine +
                        string.Format(
                            "... and {0} more.",
                            result.Errors.Count - 10);
                }
            }

            MessageBox.Show(
                this,
                summary,
                "Merge Files",
                MessageBoxButtons.OK,
                result.Errors.Count == 0
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);
        }

        private MergeOptions BuildOptions()
        {
            var rootPath = txtProjectFolder.Text.Trim();

            if (string.IsNullOrWhiteSpace(rootPath))
            {
                ShowValidationMessage(
                    "Please select the root folder of the project.");
                return null;
            }

            if (!Directory.Exists(rootPath))
            {
                ShowValidationMessage(
                    "The selected project folder does not exist.");
                return null;
            }

            var extensions = ParseCommaSeparatedValues(txtExtension.Text)
                .Select(value => value.TrimStart('.').ToLowerInvariant())
                .Where(value => !string.IsNullOrWhiteSpace(value))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            if (extensions.Count == 0)
            {
                ShowValidationMessage(
                    "Enter at least one file extension, for example: cs, cshtml");
                return null;
            }

            var blockList = new HashSet<string>(
                ParseCommaSeparatedValues(txtBlockList.Text)
                    .Select(value => value.ToLowerInvariant()),
                StringComparer.OrdinalIgnoreCase);

            var outputDirectory = txtOutputFolder.Text.Trim();

            if (string.IsNullOrWhiteSpace(outputDirectory))
            {
                ShowValidationMessage(
                    "Please select an output folder.");
                return null;
            }

            try
            {
                outputDirectory =
                    Path.GetFullPath(outputDirectory);
            }
            catch (Exception)
            {
                ShowValidationMessage(
                    "The output folder path is invalid.");
                return null;
            }

            return new MergeOptions
            {
                RootPath = Path.GetFullPath(rootPath),
                OutputDirectory = outputDirectory,
                Extensions = extensions,
                BlockList = blockList
            };
        }

        private static IEnumerable<string> ParseCommaSeparatedValues(
            string value)
        {
            return (value ?? string.Empty)
                .Split(
                    new[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(item => item.Trim())
                .Where(item => !string.IsNullOrWhiteSpace(item));
        }

        private static string GetDefaultOutputDirectory()
        {
            var documents =
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);

            if (string.IsNullOrWhiteSpace(documents))
            {
                documents = Application.StartupPath;
            }

            return Path.Combine(
                documents,
                "MergeFilesByExtension");
        }

        private void SetProcessingState(bool isProcessing)
        {
            txtProjectFolder.Enabled = !isProcessing;
            btnBrowseProject.Enabled = !isProcessing;
            txtExtension.Enabled = !isProcessing;
            txtBlockList.Enabled = !isProcessing;
            txtOutputFolder.Enabled = !isProcessing;
            btnBrowseOutput.Enabled = !isProcessing;
            btnProcess.Enabled = !isProcessing;
            btnCancel.Enabled = isProcessing;
        }

        private void ShowValidationMessage(string message)
        {
            MessageBox.Show(
                this,
                message,
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_worker.IsBusy)
            {
                _worker.CancelAsync();
            }

            base.OnFormClosing(e);
        }
    }
}
