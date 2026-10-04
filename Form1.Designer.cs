namespace MergeFilesByExtension
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtBlockList = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblFolders = new System.Windows.Forms.Label();
            this.lblExtensions = new System.Windows.Forms.Label();
            this.lblBlockList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFolders
            // 
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.ItemHeight = 16;
            this.lstFolders.Location = new System.Drawing.Point(16, 31);
            this.lstFolders.Margin = new System.Windows.Forms.Padding(4);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(399, 84);
            this.lstFolders.TabIndex = 0;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(424, 31);
            this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(133, 28);
            this.btnAddFolder.TabIndex = 1;
            this.btnAddFolder.Text = "انتخاب پوشه پروژه";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(16, 158);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(399, 22);
            this.txtExtension.TabIndex = 2;
            // 
            // txtBlockList
            // 
            this.txtBlockList.Location = new System.Drawing.Point(16, 219);
            this.txtBlockList.Margin = new System.Windows.Forms.Padding(4);
            this.txtBlockList.Name = "txtBlockList";
            this.txtBlockList.Size = new System.Drawing.Size(399, 22);
            this.txtBlockList.TabIndex = 4;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(424, 215);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(133, 28);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "شروع پردازش";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblFolders
            // 
            this.lblFolders.AutoSize = true;
            this.lblFolders.Location = new System.Drawing.Point(16, 11);
            this.lblFolders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolders.Name = "lblFolders";
            this.lblFolders.Size = new System.Drawing.Size(98, 16);
            this.lblFolders.TabIndex = 6;
            this.lblFolders.Text = "پوشه اصلی پروژه:";
            // 
            // lblExtensions
            // 
            this.lblExtensions.AutoSize = true;
            this.lblExtensions.Location = new System.Drawing.Point(16, 138);
            this.lblExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtensions.Name = "lblExtensions";
            this.lblExtensions.Size = new System.Drawing.Size(176, 16);
            this.lblExtensions.TabIndex = 7;
            this.lblExtensions.Text = "پسوند فایل‌ها (مثلاً: cs,cshtml):";
            // 
            // lblBlockList
            // 
            this.lblBlockList.AutoSize = true;
            this.lblBlockList.Location = new System.Drawing.Point(16, 199);
            this.lblBlockList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlockList.Name = "lblBlockList";
            this.lblBlockList.Size = new System.Drawing.Size(326, 16);
            this.lblBlockList.TabIndex = 9;
            this.lblBlockList.Text = "اسم پوشه‌ها یا فایل‌هایی که پردازش نشوند (با کاما جدا کنید):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 266);
            this.Controls.Add(this.lblBlockList);
            this.Controls.Add(this.lblExtensions);
            this.Controls.Add(this.lblFolders);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtBlockList);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.lstFolders);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Module Code Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtBlockList;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblFolders;
        private System.Windows.Forms.Label lblExtensions;
        private System.Windows.Forms.Label lblBlockList;
    }
}
