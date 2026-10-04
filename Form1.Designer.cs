namespace MergeFilesByExtension
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpProject = new System.Windows.Forms.GroupBox();
            this.btnBrowseProject = new System.Windows.Forms.Button();
            this.txtProjectFolder = new System.Windows.Forms.TextBox();
            this.lblProjectFolder = new System.Windows.Forms.Label();
            this.grpRules = new System.Windows.Forms.GroupBox();
            this.lblBlockListHint = new System.Windows.Forms.Label();
            this.txtBlockList = new System.Windows.Forms.TextBox();
            this.lblBlockList = new System.Windows.Forms.Label();
            this.lblExtensionHint = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lblExtensions = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpenOutput = new System.Windows.Forms.Button();
            this.grpProject.SuspendLayout();
            this.grpRules.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                16F,
                System.Drawing.FontStyle.Bold);
            this.lblTitle.Location =
                new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size =
                new System.Drawing.Size(259, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Merge Files by Extension";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.ForeColor =
                System.Drawing.Color.DimGray;
            this.lblSubtitle.Location =
                new System.Drawing.Point(26, 55);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size =
                new System.Drawing.Size(533, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text =
                "Collect source files by module and export them as readable text files.";
            // 
            // grpProject
            // 
            this.grpProject.Controls.Add(
                this.btnBrowseProject);
            this.grpProject.Controls.Add(
                this.txtProjectFolder);
            this.grpProject.Controls.Add(
                this.lblProjectFolder);
            this.grpProject.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.grpProject.Location =
                new System.Drawing.Point(24, 84);
            this.grpProject.Name = "grpProject";
            this.grpProject.Padding =
                new System.Windows.Forms.Padding(12);
            this.grpProject.Size =
                new System.Drawing.Size(712, 91);
            this.grpProject.TabIndex = 2;
            this.grpProject.TabStop = false;
            this.grpProject.Text = "Project";
            // 
            // btnBrowseProject
            // 
            this.btnBrowseProject.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.btnBrowseProject.Location =
                new System.Drawing.Point(600, 38);
            this.btnBrowseProject.Name =
                "btnBrowseProject";
            this.btnBrowseProject.Size =
                new System.Drawing.Size(94, 28);
            this.btnBrowseProject.TabIndex = 2;
            this.btnBrowseProject.Text = "Browse...";
            this.btnBrowseProject.UseVisualStyleBackColor = true;
            this.btnBrowseProject.Click +=
                new System.EventHandler(
                    this.btnBrowseProject_Click);
            // 
            // txtProjectFolder
            // 
            this.txtProjectFolder.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.txtProjectFolder.Location =
                new System.Drawing.Point(16, 39);
            this.txtProjectFolder.Name =
                "txtProjectFolder";
            this.txtProjectFolder.Size =
                new System.Drawing.Size(570, 23);
            this.txtProjectFolder.TabIndex = 1;
            // 
            // lblProjectFolder
            // 
            this.lblProjectFolder.AutoSize = true;
            this.lblProjectFolder.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.lblProjectFolder.Location =
                new System.Drawing.Point(16, 20);
            this.lblProjectFolder.Name =
                "lblProjectFolder";
            this.lblProjectFolder.Size =
                new System.Drawing.Size(228, 15);
            this.lblProjectFolder.TabIndex = 0;
            this.lblProjectFolder.Text =
                "Root folder (top-level module folders):";
            // 
            // grpRules
            // 
            this.grpRules.Controls.Add(
                this.lblBlockListHint);
            this.grpRules.Controls.Add(
                this.txtBlockList);
            this.grpRules.Controls.Add(
                this.lblBlockList);
            this.grpRules.Controls.Add(
                this.lblExtensionHint);
            this.grpRules.Controls.Add(
                this.txtExtension);
            this.grpRules.Controls.Add(
                this.lblExtensions);
            this.grpRules.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.grpRules.Location =
                new System.Drawing.Point(24, 187);
            this.grpRules.Name = "grpRules";
            this.grpRules.Padding =
                new System.Windows.Forms.Padding(12);
            this.grpRules.Size =
                new System.Drawing.Size(712, 148);
            this.grpRules.TabIndex = 3;
            this.grpRules.TabStop = false;
            this.grpRules.Text = "Merge rules";
            // 
            // lblExtensions
            // 
            this.lblExtensions.AutoSize = true;
            this.lblExtensions.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.lblExtensions.Location =
                new System.Drawing.Point(16, 22);
            this.lblExtensions.Name =
                "lblExtensions";
            this.lblExtensions.Size =
                new System.Drawing.Size(126, 15);
            this.lblExtensions.TabIndex = 0;
            this.lblExtensions.Text =
                "File extensions:";
            // 
            // txtExtension
            // 
            this.txtExtension.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.txtExtension.Location =
                new System.Drawing.Point(16, 40);
            this.txtExtension.Name =
                "txtExtension";
            this.txtExtension.Size =
                new System.Drawing.Size(270, 23);
            this.txtExtension.TabIndex = 1;
            // 
            // lblExtensionHint
            // 
            this.lblExtensionHint.AutoSize = true;
            this.lblExtensionHint.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);
            this.lblExtensionHint.ForeColor =
                System.Drawing.Color.DimGray;
            this.lblExtensionHint.Location =
                new System.Drawing.Point(301, 43);
            this.lblExtensionHint.Name =
                "lblExtensionHint";
            this.lblExtensionHint.Size =
                new System.Drawing.Size(391, 15);
            this.lblExtensionHint.TabIndex = 2;
            this.lblExtensionHint.Text =
                "Example: cs, cshtml, json    (leading dots are optional)";
            // 
            // lblBlockList
            // 
            this.lblBlockList.AutoSize = true;
            this.lblBlockList.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.lblBlockList.Location =
                new System.Drawing.Point(16, 77);
            this.lblBlockList.Name =
                "lblBlockList";
            this.lblBlockList.Size =
                new System.Drawing.Size(238, 15);
            this.lblBlockList.TabIndex = 3;
            this.lblBlockList.Text =
                "Exclude folders / files (comma-separated):";
            // 
            // txtBlockList
            // 
            this.txtBlockList.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.txtBlockList.Location =
                new System.Drawing.Point(16, 95);
            this.txtBlockList.Name =
                "txtBlockList";
            this.txtBlockList.Size =
                new System.Drawing.Size(676, 23);
            this.txtBlockList.TabIndex = 4;
            // 
            // lblBlockListHint
            // 
            this.lblBlockListHint.AutoSize = true;
            this.lblBlockListHint.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);
            this.lblBlockListHint.ForeColor =
                System.Drawing.Color.DimGray;
            this.lblBlockListHint.Location =
                new System.Drawing.Point(301, 79);
            this.lblBlockListHint.Name =
                "lblBlockListHint";
            this.lblBlockListHint.Size =
                new System.Drawing.Size(391, 15);
            this.lblBlockListHint.TabIndex = 5;
            this.lblBlockListHint.Text =
                "Case-insensitive names. Example: Migrations, Tests, generated.cs";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(
                this.btnBrowseOutput);
            this.grpOutput.Controls.Add(
                this.txtOutputFolder);
            this.grpOutput.Controls.Add(
                this.lblOutputFolder);
            this.grpOutput.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.grpOutput.Location =
                new System.Drawing.Point(24, 349);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding =
                new System.Windows.Forms.Padding(12);
            this.grpOutput.Size =
                new System.Drawing.Size(712, 91);
            this.grpOutput.TabIndex = 4;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.btnBrowseOutput.Location =
                new System.Drawing.Point(600, 38);
            this.btnBrowseOutput.Name =
                "btnBrowseOutput";
            this.btnBrowseOutput.Size =
                new System.Drawing.Size(94, 28);
            this.btnBrowseOutput.TabIndex = 2;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click +=
                new System.EventHandler(
                    this.btnBrowseOutput_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.txtOutputFolder.Location =
                new System.Drawing.Point(16, 39);
            this.txtOutputFolder.Name =
                "txtOutputFolder";
            this.txtOutputFolder.Size =
                new System.Drawing.Size(570, 23);
            this.txtOutputFolder.TabIndex = 1;
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.lblOutputFolder.Location =
                new System.Drawing.Point(16, 20);
            this.lblOutputFolder.Name =
                "lblOutputFolder";
            this.lblOutputFolder.Size =
                new System.Drawing.Size(292, 15);
            this.lblOutputFolder.TabIndex = 0;
            this.lblOutputFolder.Text =
                "Merged files will be created here (one .txt per module):";
            // 
            // progressBar
            // 
            this.progressBar.Location =
                new System.Drawing.Point(24, 459);
            this.progressBar.Name =
                "progressBar";
            this.progressBar.Size =
                new System.Drawing.Size(410, 18);
            this.progressBar.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.ForeColor =
                System.Drawing.Color.DimGray;
            this.lblStatus.Location =
                new System.Drawing.Point(24, 483);
            this.lblStatus.Name =
                "lblStatus";
            this.lblStatus.Size =
                new System.Drawing.Size(712, 24);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Ready";
            // 
            // btnProcess
            // 
            this.btnProcess.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold);
            this.btnProcess.Location =
                new System.Drawing.Point(452, 456);
            this.btnProcess.Name =
                "btnProcess";
            this.btnProcess.Size =
                new System.Drawing.Size(90, 24);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "Start merge";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click +=
                new System.EventHandler(
                    this.btnProcess_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.btnCancel.Location =
                new System.Drawing.Point(548, 456);
            this.btnCancel.Name =
                "btnCancel";
            this.btnCancel.Size =
                new System.Drawing.Size(90, 24);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click +=
                new System.EventHandler(
                    this.btnCancel_Click);
            // 
            // btnOpenOutput
            // 
            this.btnOpenOutput.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.btnOpenOutput.Location =
                new System.Drawing.Point(644, 456);
            this.btnOpenOutput.Name =
                "btnOpenOutput";
            this.btnOpenOutput.Size =
                new System.Drawing.Size(92, 24);
            this.btnOpenOutput.TabIndex = 9;
            this.btnOpenOutput.Text = "Open folder";
            this.btnOpenOutput.UseVisualStyleBackColor = true;
            this.btnOpenOutput.Click +=
                new System.EventHandler(
                    this.btnOpenOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize =
                new System.Drawing.Size(760, 525);
            this.Controls.Add(
                this.btnOpenOutput);
            this.Controls.Add(
                this.btnCancel);
            this.Controls.Add(
                this.btnProcess);
            this.Controls.Add(
                this.lblStatus);
            this.Controls.Add(
                this.progressBar);
            this.Controls.Add(
                this.grpOutput);
            this.Controls.Add(
                this.grpRules);
            this.Controls.Add(
                this.grpProject);
            this.Controls.Add(
                this.lblSubtitle);
            this.Controls.Add(
                this.lblTitle);
            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize =
                new System.Drawing.Size(760, 525);
            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Files by Extension";
            this.grpProject.ResumeLayout(false);
            this.grpProject.PerformLayout();
            this.grpRules.ResumeLayout(false);
            this.grpRules.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpProject;
        private System.Windows.Forms.Button btnBrowseProject;
        private System.Windows.Forms.TextBox txtProjectFolder;
        private System.Windows.Forms.Label lblProjectFolder;
        private System.Windows.Forms.GroupBox grpRules;
        private System.Windows.Forms.Label lblBlockListHint;
        private System.Windows.Forms.TextBox txtBlockList;
        private System.Windows.Forms.Label lblBlockList;
        private System.Windows.Forms.Label lblExtensionHint;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label lblExtensions;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOpenOutput;
    }
}
