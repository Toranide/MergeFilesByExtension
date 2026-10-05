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
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerInfoCard = new CardPanel();
            this.lblHeaderToolIcon = new System.Windows.Forms.Label();
            this.lblHeaderToolTitle = new System.Windows.Forms.Label();
            this.lblHeaderToolMeta = new System.Windows.Forms.Label();
            this.headerTextPanel = new System.Windows.Forms.Panel();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picHeaderLogo = new System.Windows.Forms.PictureBox();

            this.projectCard = new CardPanel();
            this.projectHeaderIcon = new System.Windows.Forms.Label();
            this.projectHeaderTitle = new System.Windows.Forms.Label();
            this.projectHeaderDescription = new System.Windows.Forms.Label();
            this.lblProjectFolder = new System.Windows.Forms.Label();
            this.projectPathPanel = new CardPanel();
            this.txtProjectFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseProject = new RoundedButton();

            this.rulesCard = new CardPanel();
            this.rulesHeaderIcon = new System.Windows.Forms.Label();
            this.rulesHeaderTitle = new System.Windows.Forms.Label();
            this.rulesHeaderDescription = new System.Windows.Forms.Label();
            this.rulesGrid = new System.Windows.Forms.TableLayoutPanel();
            this.extensionsPanel = new System.Windows.Forms.Panel();
            this.lblExtensions = new System.Windows.Forms.Label();
            this.extensionInputPanel = new CardPanel();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lblExtensionHint = new System.Windows.Forms.Label();
            this.blockListColumn = new System.Windows.Forms.Panel();
            this.lblBlockList = new System.Windows.Forms.Label();
            this.blockListInputPanel = new CardPanel();
            this.txtBlockList = new System.Windows.Forms.TextBox();
            this.lblBlockListHint = new System.Windows.Forms.Label();

            this.outputCard = new CardPanel();
            this.outputHeaderIcon = new System.Windows.Forms.Label();
            this.outputHeaderTitle = new System.Windows.Forms.Label();
            this.outputHeaderDescription = new System.Windows.Forms.Label();
            this.outputContentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.outputPathPanel = new CardPanel();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new RoundedButton();
            this.btnOpenOutput = new RoundedButton();

            this.statusCard = new CardPanel();
            this.statusIconPanel = new System.Windows.Forms.Panel();
            this.lblStatusIcon = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusDetail = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProcess = new RoundedButton();
            this.btnCancel = new RoundedButton();

            this.rootLayout.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.headerInfoCard.SuspendLayout();
            this.headerTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderLogo)).BeginInit();
            this.projectCard.SuspendLayout();
            this.projectPathPanel.SuspendLayout();
            this.rulesCard.SuspendLayout();
            this.rulesGrid.SuspendLayout();
            this.extensionsPanel.SuspendLayout();
            this.extensionInputPanel.SuspendLayout();
            this.blockListColumn.SuspendLayout();
            this.blockListInputPanel.SuspendLayout();
            this.outputCard.SuspendLayout();
            this.outputContentPanel.SuspendLayout();
            this.outputPathPanel.SuspendLayout();
            this.statusCard.SuspendLayout();
            this.statusIconPanel.SuspendLayout();
            this.statusButtonsPanel.SuspendLayout();
            this.SuspendLayout();

            // rootLayout
            this.rootLayout.AutoSize = false;
            this.rootLayout.BackColor =
                System.Drawing.Color.FromArgb(
                245,
                249,
                253);
            this.rootLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rootLayout.ColumnCount = 1;
            this.rootLayout.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent,
                    100F));
            this.rootLayout.Controls.Add(
                this.headerPanel,
                0,
                0);
            this.rootLayout.Controls.Add(
                this.projectCard,
                0,
                1);
            this.rootLayout.Controls.Add(
                this.rulesCard,
                0,
                2);
            this.rootLayout.Controls.Add(
                this.outputCard,
                0,
                3);
            this.rootLayout.Controls.Add(
                this.statusCard,
                0,
                4);
            this.rootLayout.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Padding =
                new System.Windows.Forms.Padding(2);
            this.rootLayout.RowCount = 5;
            this.rootLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    96F));
            this.rootLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    140F));
            this.rootLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    170F));
            this.rootLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    125F));
            this.rootLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    80F));
            this.rootLayout.Location =
                new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.Size =
                new System.Drawing.Size(964, 611);
            this.rootLayout.TabIndex = 0;

            // headerPanel
            this.headerPanel.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.BackColor =
                System.Drawing.Color.FromArgb(
                245,
                249,
                253);
            this.headerPanel.Controls.Add(
                this.headerInfoCard);
            this.headerPanel.Controls.Add(
                this.headerTextPanel);
            this.headerPanel.Controls.Add(
                this.picHeaderLogo);
            this.headerPanel.Location =
                new System.Drawing.Point(5, 5);
            this.headerPanel.Margin =
                new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size =
                new System.Drawing.Size(1184, 118);
            this.headerPanel.TabIndex = 0;

            // picHeaderLogo
            this.picHeaderLogo.BackColor =
                System.Drawing.Color.Transparent;
            this.picHeaderLogo.Location =
                new System.Drawing.Point(4, 10);
            this.picHeaderLogo.Name = "picHeaderLogo";
            this.picHeaderLogo.Size =
                new System.Drawing.Size(64, 64);
            this.picHeaderLogo.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeaderLogo.TabIndex = 0;
            this.picHeaderLogo.TabStop = false;

            // headerTextPanel
            this.headerTextPanel.BackColor =
                System.Drawing.Color.FromArgb(
                245,
                249,
                253);
            this.headerTextPanel.Controls.Add(
                this.lblTagline);
            this.headerTextPanel.Controls.Add(
                this.lblHeaderSubtitle);
            this.headerTextPanel.Controls.Add(
                this.lblTitle);
            this.headerTextPanel.Location =
                new System.Drawing.Point(80, 6);
            this.headerTextPanel.Name = "headerTextPanel";
            this.headerTextPanel.Size =
                new System.Drawing.Size(610, 84);
            this.headerTextPanel.TabIndex = 1;

            // lblTitle
            this.lblTitle.BackColor =
                System.Drawing.Color.Transparent;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    20F,
                    System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(22, 51, 91);
            this.lblTitle.Location =
                new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text =
                "Merge Files by Extension";

            // lblHeaderSubtitle
            this.lblHeaderSubtitle.BackColor =
                System.Drawing.Color.Transparent;
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.lblHeaderSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(82, 111, 150);
            this.lblHeaderSubtitle.Location =
                new System.Drawing.Point(1, 42);
            this.lblHeaderSubtitle.Name =
                "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Text =
                "Collect source files by module and export them as readable text files.";

            // lblTagline
            this.lblTagline.BackColor =
                System.Drawing.Color.Transparent;
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.lblTagline.ForeColor =
                System.Drawing.Color.FromArgb(94, 123, 160);
            this.lblTagline.Location =
                new System.Drawing.Point(2, 68);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Text =
                "A simple and powerful tool for developers.";

            // headerInfoCard
            this.headerInfoCard.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.headerInfoCard.BorderColor =
                System.Drawing.Color.FromArgb(
                    214,
                    226,
                    240);
            this.headerInfoCard.FillColor =
                
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.headerInfoCard.CornerRadius = 14;
            this.headerInfoCard.Controls.Add(
                this.lblHeaderToolMeta);
            this.headerInfoCard.Controls.Add(
                this.lblHeaderToolTitle);
            this.headerInfoCard.Controls.Add(
                this.lblHeaderToolIcon);
            this.headerInfoCard.Location =
                new System.Drawing.Point(742, 10);
            this.headerInfoCard.Name = "headerInfoCard";
            this.headerInfoCard.Size =
                new System.Drawing.Size(210, 64);
            this.headerInfoCard.TabIndex = 2;

            // lblHeaderToolIcon
            this.lblHeaderToolIcon.BackColor =
                System.Drawing.Color.Transparent;
            this.lblHeaderToolIcon.AutoSize = true;
            this.lblHeaderToolIcon.Font =
                new System.Drawing.Font(
                    "Segoe MDL2 Assets",
                    18F);
            this.lblHeaderToolIcon.ForeColor =
                System.Drawing.Color.FromArgb(80, 104, 147);
            this.lblHeaderToolIcon.Location =
                new System.Drawing.Point(14, 18);
            this.lblHeaderToolIcon.Name =
                "lblHeaderToolIcon";
            this.lblHeaderToolIcon.Text = "\uE8A5";

            // lblHeaderToolTitle
            this.lblHeaderToolTitle.BackColor =
                System.Drawing.Color.Transparent;
            this.lblHeaderToolTitle.AutoSize = true;
            this.lblHeaderToolTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10.5F,
                    System.Drawing.FontStyle.Bold);
            this.lblHeaderToolTitle.ForeColor =
                System.Drawing.Color.FromArgb(85, 114, 153);
            this.lblHeaderToolTitle.Location =
                new System.Drawing.Point(50, 15);
            this.lblHeaderToolTitle.Name =
                "lblHeaderToolTitle";
            this.lblHeaderToolTitle.Text =
                "Developer Tool";

            // lblHeaderToolMeta
            this.lblHeaderToolMeta.BackColor =
                System.Drawing.Color.Transparent;
            this.lblHeaderToolMeta.AutoSize = true;
            this.lblHeaderToolMeta.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);
            this.lblHeaderToolMeta.ForeColor =
                System.Drawing.Color.FromArgb(104, 131, 166);
            this.lblHeaderToolMeta.Location =
                new System.Drawing.Point(50, 36);
            this.lblHeaderToolMeta.Name =
                "lblHeaderToolMeta";
            this.lblHeaderToolMeta.Text =
                "Windows  •  .NET Framework";

            // projectCard
            this.projectCard.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.projectCard.FillColor =
                
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.projectCard.BorderColor =
                System.Drawing.Color.FromArgb(216, 228, 241);
            this.projectCard.CornerRadius = 14;
            this.projectCard.Controls.Add(
                this.btnBrowseProject);
            this.projectCard.Controls.Add(
                this.projectPathPanel);
            this.projectCard.Controls.Add(
                this.lblProjectFolder);
            this.projectCard.Controls.Add(
                this.projectHeaderDescription);
            this.projectCard.Controls.Add(
                this.projectHeaderTitle);
            this.projectCard.Controls.Add(
                this.projectHeaderIcon);
            this.projectCard.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.projectCard.Location =
                new System.Drawing.Point(5, 133);
            this.projectCard.Margin =
                new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.projectCard.Name =
                "projectCard";
            this.projectCard.Padding =
                new System.Windows.Forms.Padding(18, 12, 18, 12);
            this.projectCard.TabIndex = 1;

            // projectHeaderIcon
            this.projectHeaderIcon.BackColor =
                System.Drawing.Color.Transparent;
            this.projectHeaderIcon.AutoSize = true;
            this.projectHeaderIcon.Font =
                new System.Drawing.Font(
                    "Segoe MDL2 Assets",
                    19F);
            this.projectHeaderIcon.ForeColor =
                System.Drawing.Color.FromArgb(16, 91, 180);
            this.projectHeaderIcon.Location =
                new System.Drawing.Point(20, 14);
            this.projectHeaderIcon.Text = "\uE8B7";

            // projectHeaderTitle
            this.projectHeaderTitle.BackColor =
                System.Drawing.Color.Transparent;
            this.projectHeaderTitle.AutoSize = true;
            this.projectHeaderTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F,
                    System.Drawing.FontStyle.Bold);
            this.projectHeaderTitle.ForeColor =
                System.Drawing.Color.FromArgb(25, 58, 103);
            this.projectHeaderTitle.Location =
                new System.Drawing.Point(58, 12);
            this.projectHeaderTitle.Text = "Project";

            // projectHeaderDescription
            this.projectHeaderDescription.BackColor =
                System.Drawing.Color.Transparent;
            this.projectHeaderDescription.AutoSize = true;
            this.projectHeaderDescription.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.projectHeaderDescription.ForeColor =
                System.Drawing.Color.FromArgb(102, 130, 166);
            this.projectHeaderDescription.Location =
                new System.Drawing.Point(59, 36);
            this.projectHeaderDescription.Text =
                "Select the root folder of your solution or project.";

            // lblProjectFolder
            this.lblProjectFolder.BackColor =
                System.Drawing.Color.Transparent;
            this.lblProjectFolder.AutoSize = true;
            this.lblProjectFolder.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);
            this.lblProjectFolder.ForeColor =
                System.Drawing.Color.FromArgb(25, 55, 98);
            this.lblProjectFolder.Location =
                new System.Drawing.Point(20, 65);
            this.lblProjectFolder.Text =
                "Root folder (top-level module folders):";

            // projectPathPanel
            this.projectPathPanel.BackColor =
                System.Drawing.Color.Transparent;
            this.projectPathPanel.FillColor =
                
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.projectPathPanel.BorderColor =
                System.Drawing.Color.FromArgb(196, 213, 232);
            this.projectPathPanel.CornerRadius = 8;
            this.projectPathPanel.Padding =
                new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.projectPathPanel.Location =
                new System.Drawing.Point(20, 90);
            this.projectPathPanel.Name =
                "projectPathPanel";
            this.projectPathPanel.Size =
                new System.Drawing.Size(760, 34);
            this.projectPathPanel.TabIndex = 4;
            this.projectPathPanel.Controls.Add(
                this.txtProjectFolder);

            // txtProjectFolder
            this.txtProjectFolder.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.txtProjectFolder.Padding =
                new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.txtProjectFolder.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.txtProjectFolder.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.txtProjectFolder.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.txtProjectFolder.ForeColor =
                System.Drawing.Color.FromArgb(33, 58, 91);
            this.txtProjectFolder.Name =
                "txtProjectFolder";
            this.txtProjectFolder.TabIndex = 0;

            // btnBrowseProject
            this.btnBrowseProject.ButtonBackColor =
                System.Drawing.Color.FromArgb(239, 244, 250);
            this.btnBrowseProject.ButtonBorderColor =
                System.Drawing.Color.FromArgb(192, 211, 234);
            this.btnBrowseProject.ButtonTextColor =
                System.Drawing.Color.FromArgb(48, 92, 140);
            this.btnBrowseProject.HoverBackColor =
                System.Drawing.Color.FromArgb(231, 240, 251);
            this.btnBrowseProject.CornerRadius = 9;
            this.btnBrowseProject.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);
            this.btnBrowseProject.Location =
                new System.Drawing.Point(800, 90);
            this.btnBrowseProject.Name =
                "btnBrowseProject";
            this.btnBrowseProject.Size =
                new System.Drawing.Size(150, 34);
            this.btnBrowseProject.Text =
                "Browse...";
            this.btnBrowseProject.Click +=
                new System.EventHandler(
                    this.btnBrowseProject_Click);

            // rulesCard
            this.rulesCard.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.rulesCard.FillColor =
                
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.rulesCard.BorderColor =
                System.Drawing.Color.FromArgb(216, 228, 241);
            this.rulesCard.CornerRadius = 14;
            this.rulesCard.Controls.Add(
                this.rulesGrid);
            this.rulesCard.Controls.Add(
                this.rulesHeaderDescription);
            this.rulesCard.Controls.Add(
                this.rulesHeaderTitle);
            this.rulesCard.Controls.Add(
                this.rulesHeaderIcon);
            this.rulesCard.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.rulesCard.Location =
                new System.Drawing.Point(5, 321);
            this.rulesCard.Margin =
                new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.rulesCard.Name =
                "rulesCard";
            this.rulesCard.Padding =
                new System.Windows.Forms.Padding(18, 12, 18, 12);
            this.rulesCard.TabIndex = 2;

            // rulesHeaderIcon
            this.rulesHeaderIcon.BackColor =
                System.Drawing.Color.Transparent;
            this.rulesHeaderIcon.AutoSize = true;
            this.rulesHeaderIcon.Font =
                new System.Drawing.Font(
                    "Segoe MDL2 Assets",
                    19F);
            this.rulesHeaderIcon.ForeColor =
                System.Drawing.Color.FromArgb(16, 91, 180);
            this.rulesHeaderIcon.Location =
                new System.Drawing.Point(20, 12);
            this.rulesHeaderIcon.Text = "\uE713";

            // rulesHeaderTitle
            this.rulesHeaderTitle.BackColor =
                System.Drawing.Color.Transparent;
            this.rulesHeaderTitle.AutoSize = true;
            this.rulesHeaderTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F,
                    System.Drawing.FontStyle.Bold);
            this.rulesHeaderTitle.ForeColor =
                System.Drawing.Color.FromArgb(25, 58, 103);
            this.rulesHeaderTitle.Location =
                new System.Drawing.Point(58, 12);
            this.rulesHeaderTitle.Text = "Merge rules";

            // rulesHeaderDescription
            this.rulesHeaderDescription.BackColor =
                System.Drawing.Color.Transparent;
            this.rulesHeaderDescription.AutoSize = true;
            this.rulesHeaderDescription.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.rulesHeaderDescription.ForeColor =
                System.Drawing.Color.FromArgb(102, 130, 166);
            this.rulesHeaderDescription.Location =
                new System.Drawing.Point(59, 36);
            this.rulesHeaderDescription.Text =
                "Define which files to include and which folders / files to exclude.";

            // rulesGrid
            this.rulesGrid.ColumnCount = 2;
            this.rulesGrid.BackColor =
                System.Drawing.Color.FromArgb(
                245,
                249,
                253);
            this.rulesGrid.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent,
                    50F));
            this.rulesGrid.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent,
                    50F));
            this.rulesGrid.RowCount = 1;
            this.rulesGrid.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent,
                    100F));
            this.rulesGrid.Controls.Add(
                this.extensionsPanel,
                0,
                0);
            this.rulesGrid.Controls.Add(
                this.blockListColumn,
                1,
                0);
            this.rulesGrid.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.rulesGrid.Location =
                new System.Drawing.Point(18, 66);
            this.rulesGrid.Margin =
                new System.Windows.Forms.Padding(0);
            this.rulesGrid.Name =
                "rulesGrid";
            this.rulesGrid.Size =
                new System.Drawing.Size(928, 86);
            this.rulesGrid.TabIndex = 3;

            // extensionsPanel
            this.extensionsPanel.Controls.Add(
                this.lblExtensionHint);
            this.extensionsPanel.BackColor =
                System.Drawing.Color.FromArgb(
                245,
                249,
                253);
            this.extensionsPanel.Controls.Add(
                this.extensionInputPanel);
            this.extensionsPanel.Controls.Add(
                this.lblExtensions);
            this.extensionsPanel.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.extensionsPanel.Padding =
                new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.extensionsPanel.TabIndex = 0;

            // lblExtensions
            this.lblExtensions.BackColor =
                System.Drawing.Color.Transparent;
            this.lblExtensions.AutoSize = true;
            this.lblExtensions.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);
            this.lblExtensions.ForeColor =
                System.Drawing.Color.FromArgb(25, 55, 98);
            this.lblExtensions.Location =
                new System.Drawing.Point(0, 0);
            this.lblExtensions.Text =
                "File extensions:";

            // extensionInputPanel
            this.extensionInputPanel.BackColor =
                System.Drawing.Color.Transparent;
            this.extensionInputPanel.FillColor =
                
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.extensionInputPanel.BorderColor =
                System.Drawing.Color.FromArgb(196, 213, 232);
            this.extensionInputPanel.CornerRadius = 8;
            this.extensionInputPanel.Padding =
                new System.Windows.Forms.Padding(10, 1, 10, 1);
            this.extensionInputPanel.Location =
                new System.Drawing.Point(0, 22);
            this.extensionInputPanel.Size =
                new System.Drawing.Size(430, 34);
            this.extensionInputPanel.Controls.Add(
                this.txtExtension);

            // txtExtension
            this.txtExtension.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.txtExtension.Padding =
                new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.txtExtension.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.txtExtension.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.txtExtension.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.txtExtension.ForeColor =
                System.Drawing.Color.FromArgb(33, 58, 91);
            this.txtExtension.Name =
                "txtExtension";

            // lblExtensionHint
            this.lblExtensionHint.BackColor =
                System.Drawing.Color.Transparent;
            this.lblExtensionHint.AutoSize = true;
            this.lblExtensionHint.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.75F);
            this.lblExtensionHint.ForeColor =
                System.Drawing.Color.FromArgb(104, 132, 168);
            this.lblExtensionHint.Location =
                new System.Drawing.Point(0, 59);
            this.lblExtensionHint.Text =
                "Example: cs, cshtml, json   (leading dots are optional)";

            // blockListColumn
            this.blockListColumn.Controls.Add(
                this.lblBlockListHint);
            this.blockListColumn.BackColor =
                System.Drawing.Color.FromArgb(
                245,
                249,
                253);
            this.blockListColumn.Controls.Add(
                this.blockListInputPanel);
            this.blockListColumn.Controls.Add(
                this.lblBlockList);
            this.blockListColumn.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.blockListColumn.Padding =
                new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.blockListColumn.TabIndex = 1;

            // lblBlockList
            this.lblBlockList.BackColor =
                System.Drawing.Color.Transparent;
            this.lblBlockList.AutoSize = true;
            this.lblBlockList.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);
            this.lblBlockList.ForeColor =
                System.Drawing.Color.FromArgb(25, 55, 98);
            this.lblBlockList.Location =
                new System.Drawing.Point(10, 0);
            this.lblBlockList.Text =
                "Exclude folders / files (comma-separated):";

            // blockListInputPanel
            this.blockListInputPanel.BackColor =
                System.Drawing.Color.Transparent;
            this.blockListInputPanel.FillColor =
                
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.blockListInputPanel.BorderColor =
                System.Drawing.Color.FromArgb(196, 213, 232);
            this.blockListInputPanel.CornerRadius = 8;
            this.blockListInputPanel.Padding =
                new System.Windows.Forms.Padding(10, 1, 10, 1);
            this.blockListInputPanel.Location =
                new System.Drawing.Point(10, 22);
            this.blockListInputPanel.Size =
                new System.Drawing.Size(430, 34);
            this.blockListInputPanel.Controls.Add(
                this.txtBlockList);

            // txtBlockList
            this.txtBlockList.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.txtBlockList.Padding =
                new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.txtBlockList.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.txtBlockList.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.txtBlockList.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.txtBlockList.ForeColor =
                System.Drawing.Color.FromArgb(33, 58, 91);
            this.txtBlockList.Name =
                "txtBlockList";

            // lblBlockListHint
            this.lblBlockListHint.BackColor =
                System.Drawing.Color.Transparent;
            this.lblBlockListHint.AutoSize = true;
            this.lblBlockListHint.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.75F);
            this.lblBlockListHint.ForeColor =
                System.Drawing.Color.FromArgb(104, 132, 168);
            this.lblBlockListHint.Location =
                new System.Drawing.Point(10, 59);
            this.lblBlockListHint.Text =
                "Case-insensitive names. Example: Migrations, Tests, generated.cs";

            // outputCard
            this.outputCard.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.outputCard.FillColor =
                
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.outputCard.BorderColor =
                System.Drawing.Color.FromArgb(216, 228, 241);
            this.outputCard.CornerRadius = 14;
            this.outputCard.Controls.Add(
                this.outputContentPanel);
            this.outputCard.Controls.Add(
                this.outputHeaderDescription);
            this.outputCard.Controls.Add(
                this.outputHeaderTitle);
            this.outputCard.Controls.Add(
                this.outputHeaderIcon);
            this.outputCard.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.outputCard.Location =
                new System.Drawing.Point(5, 547);
            this.outputCard.Margin =
                new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.outputCard.Name =
                "outputCard";
            this.outputCard.Padding =
                new System.Windows.Forms.Padding(18, 12, 18, 12);
            this.outputCard.TabIndex = 3;

            // outputHeaderIcon
            this.outputHeaderIcon.BackColor =
                System.Drawing.Color.Transparent;
            this.outputHeaderIcon.AutoSize = true;
            this.outputHeaderIcon.Font =
                new System.Drawing.Font(
                    "Segoe MDL2 Assets",
                    19F);
            this.outputHeaderIcon.ForeColor =
                System.Drawing.Color.FromArgb(16, 91, 180);
            this.outputHeaderIcon.Location =
                new System.Drawing.Point(20, 12);
            this.outputHeaderIcon.Text = "\uE896";

            // outputHeaderTitle
            this.outputHeaderTitle.BackColor =
                System.Drawing.Color.Transparent;
            this.outputHeaderTitle.AutoSize = true;
            this.outputHeaderTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F,
                    System.Drawing.FontStyle.Bold);
            this.outputHeaderTitle.ForeColor =
                System.Drawing.Color.FromArgb(25, 58, 103);
            this.outputHeaderTitle.Location =
                new System.Drawing.Point(58, 12);
            this.outputHeaderTitle.Text =
                "Output";

            // outputHeaderDescription
            this.outputHeaderDescription.BackColor =
                System.Drawing.Color.Transparent;
            this.outputHeaderDescription.AutoSize = true;
            this.outputHeaderDescription.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.outputHeaderDescription.ForeColor =
                System.Drawing.Color.FromArgb(102, 130, 166);
            this.outputHeaderDescription.Location =
                new System.Drawing.Point(59, 36);
            this.outputHeaderDescription.Text =
                "Merged files will be created here (one .txt per module).";

            // outputContentPanel
            this.outputContentPanel.ColumnCount = 3;
            this.outputContentPanel.BackColor =
                System.Drawing.Color.FromArgb(
                245,
                249,
                253);
            this.outputContentPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent,
                    100F));
            this.outputContentPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    130F));
            this.outputContentPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    150F));
            this.outputContentPanel.RowCount = 1;
            this.outputContentPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute,
                    34F));
            this.outputContentPanel.Controls.Add(
                this.outputPathPanel,
                0,
                0);
            this.outputContentPanel.Controls.Add(
                this.btnBrowseOutput,
                1,
                0);
            this.outputContentPanel.Controls.Add(
                this.btnOpenOutput,
                2,
                0);
            this.outputContentPanel.Dock =
                System.Windows.Forms.DockStyle.Bottom;
            this.outputContentPanel.Location =
                new System.Drawing.Point(18, 70);
            this.outputContentPanel.Name =
                "outputContentPanel";
            this.outputContentPanel.Size =
                new System.Drawing.Size(928, 34);
            this.outputContentPanel.TabIndex = 4;

            // outputPathPanel
            this.outputPathPanel.BackColor =
                System.Drawing.Color.Transparent;
            this.outputPathPanel.FillColor =
                
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.outputPathPanel.BorderColor =
                System.Drawing.Color.FromArgb(196, 213, 232);
            this.outputPathPanel.CornerRadius = 8;
            this.outputPathPanel.Padding =
                new System.Windows.Forms.Padding(10, 1, 10, 1);
            this.outputPathPanel.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.outputPathPanel.Controls.Add(
                this.txtOutputFolder);
            this.outputPathPanel.TabIndex = 0;

            // txtOutputFolder
            this.txtOutputFolder.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.txtOutputFolder.Padding =
                new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.txtOutputFolder.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.txtOutputFolder.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.txtOutputFolder.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.txtOutputFolder.ForeColor =
                System.Drawing.Color.FromArgb(33, 58, 91);
            this.txtOutputFolder.Name =
                "txtOutputFolder";

            // btnBrowseOutput
            this.btnBrowseOutput.ButtonBackColor =
                System.Drawing.Color.FromArgb(242, 247, 253);
            this.btnBrowseOutput.ButtonBorderColor =
                System.Drawing.Color.FromArgb(192, 211, 234);
            this.btnBrowseOutput.ButtonTextColor =
                System.Drawing.Color.FromArgb(48, 92, 140);
            this.btnBrowseOutput.HoverBackColor =
                System.Drawing.Color.FromArgb(231, 240, 251);
            this.btnBrowseOutput.CornerRadius = 9;
            this.btnBrowseOutput.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);
            this.btnBrowseOutput.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseOutput.Margin =
                new System.Windows.Forms.Padding(12, 0, 8, 0);
            this.btnBrowseOutput.Text =
                "Browse...";
            this.btnBrowseOutput.Click +=
                new System.EventHandler(
                    this.btnBrowseOutput_Click);

            // btnOpenOutput
            this.btnOpenOutput.ButtonBackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.btnOpenOutput.ButtonBorderColor =
                System.Drawing.Color.FromArgb(13, 97, 201);
            this.btnOpenOutput.ButtonTextColor =
                System.Drawing.Color.FromArgb(13, 93, 190);
            this.btnOpenOutput.HoverBackColor =
                System.Drawing.Color.FromArgb(240, 247, 255);
            this.btnOpenOutput.CornerRadius = 9;
            this.btnOpenOutput.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);
            this.btnOpenOutput.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.btnOpenOutput.Margin =
                new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnOpenOutput.Text =
                "Open folder";
            this.btnOpenOutput.Click +=
                new System.EventHandler(
                    this.btnOpenOutput_Click);

            // statusCard
            this.statusCard.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.statusCard.FillColor =
                
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.statusCard.BorderColor =
                System.Drawing.Color.FromArgb(216, 228, 241);
            this.statusCard.CornerRadius = 14;
            this.statusCard.Controls.Add(
                this.statusButtonsPanel);
            this.statusCard.Controls.Add(
                this.progressBar);
            this.statusCard.Controls.Add(
                this.lblStatusDetail);
            this.statusCard.Controls.Add(
                this.lblStatus);
            this.statusCard.Controls.Add(
                this.statusIconPanel);
            this.statusCard.Dock =
                System.Windows.Forms.DockStyle.Fill;
            this.statusCard.Location =
                new System.Drawing.Point(5, 723);
            this.statusCard.Margin =
                new System.Windows.Forms.Padding(0);
            this.statusCard.Name =
                "statusCard";
            this.statusCard.Padding =
                new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.statusCard.TabIndex = 4;

            // statusIconPanel
            this.statusIconPanel.BackColor =
                System.Drawing.Color.FromArgb(
                245,
                249,
                253);
            this.statusIconPanel.Controls.Add(
                this.lblStatusIcon);
            this.statusIconPanel.Location =
                new System.Drawing.Point(14, 10);
            this.statusIconPanel.Size =
                new System.Drawing.Size(42, 50);
            this.statusIconPanel.TabIndex = 0;

            // lblStatusIcon
            this.lblStatusIcon.BackColor =
                System.Drawing.Color.Transparent;
            this.lblStatusIcon.AutoSize = true;
            this.lblStatusIcon.Font =
                new System.Drawing.Font(
                    "Segoe MDL2 Assets",
                    21F);
            this.lblStatusIcon.ForeColor =
                System.Drawing.Color.FromArgb(94, 126, 167);
            this.lblStatusIcon.Location =
                new System.Drawing.Point(2, 6);
            this.lblStatusIcon.Text = "\uE8A5";

            // lblStatus
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor =
                System.Drawing.Color.FromArgb(30, 61, 103);
            this.lblStatus.Location =
                new System.Drawing.Point(62, 10);
            this.lblStatus.Size =
                new System.Drawing.Size(430, 22);
            this.lblStatus.Text =
                "Ready";

            // lblStatusDetail
            this.lblStatusDetail.AutoEllipsis = true;
            this.lblStatusDetail.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);
            this.lblStatusDetail.ForeColor =
                System.Drawing.Color.FromArgb(108, 135, 169);
            this.lblStatusDetail.Location =
                new System.Drawing.Point(62, 33);
            this.lblStatusDetail.Size =
                new System.Drawing.Size(430, 20);
            this.lblStatusDetail.Text =
                "Select a folder and configure your options to start.";

            // progressBar
            this.progressBar.Location =
                new System.Drawing.Point(62, 56);
            this.progressBar.Size =
                new System.Drawing.Size(430, 5);
            this.progressBar.Style =
                System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.Visible = false;

            // statusButtonsPanel
            this.statusButtonsPanel.AutoSize = true;
            this.statusButtonsPanel.BackColor =
                System.Drawing.Color.FromArgb(
                245,
                249,
                253);
            this.statusButtonsPanel.FlowDirection =
                System.Windows.Forms.FlowDirection.LeftToRight;
            this.statusButtonsPanel.WrapContents = false;
            this.statusButtonsPanel.Anchor =
                System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Top;
            this.statusButtonsPanel.Location =
                new System.Drawing.Point(566, 14);
            this.statusButtonsPanel.Size =
                new System.Drawing.Size(364, 44);
            this.statusButtonsPanel.TabIndex = 5;
            this.statusButtonsPanel.Controls.Add(
                this.btnProcess);
            this.statusButtonsPanel.Controls.Add(
                this.btnCancel);

            // btnProcess
            this.btnProcess.ButtonBackColor =
                System.Drawing.Color.FromArgb(18, 111, 224);
            this.btnProcess.ButtonBorderColor =
                System.Drawing.Color.FromArgb(18, 111, 224);
            this.btnProcess.ButtonTextColor =
                System.Drawing.Color.White;
            this.btnProcess.HoverBackColor =
                System.Drawing.Color.FromArgb(12, 94, 198);
            this.btnProcess.CornerRadius = 10;
            this.btnProcess.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10.5F,
                    System.Drawing.FontStyle.Bold);
            this.btnProcess.Size =
                new System.Drawing.Size(204, 36);
            this.btnProcess.Margin =
                new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnProcess.Text =
                "▶  Start merge";
            this.btnProcess.Click +=
                new System.EventHandler(
                    this.btnProcess_Click);

            // btnCancel
            this.btnCancel.ButtonBackColor =
                System.Drawing.Color.FromArgb(229, 236, 245);
            this.btnCancel.ButtonBorderColor =
                System.Drawing.Color.FromArgb(229, 236, 245);
            this.btnCancel.ButtonTextColor =
                System.Drawing.Color.FromArgb(123, 145, 170);
            this.btnCancel.HoverBackColor =
                System.Drawing.Color.FromArgb(220, 229, 240);
            this.btnCancel.CornerRadius = 10;
            this.btnCancel.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10.5F,
                    System.Drawing.FontStyle.Bold);
            this.btnCancel.Size =
                new System.Drawing.Size(144, 36);
            this.btnCancel.Margin =
                new System.Windows.Forms.Padding(0);
            this.btnCancel.Text =
                "■  Cancel";
            this.btnCancel.Click +=
                new System.EventHandler(
                    this.btnCancel_Click);

            // Form1
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor =
                System.Drawing.Color.FromArgb(245, 249, 253);
            this.ClientSize =
                new System.Drawing.Size(1000, 650);
            this.Controls.Add(
                this.rootLayout);
            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);
            this.MinimumSize =
                new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text =
                "Merge Files by Extension";
            this.Padding =
                new System.Windows.Forms.Padding(18, 16, 18, 16);

            this.rootLayout.ResumeLayout(false);
            this.rootLayout.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.headerInfoCard.ResumeLayout(false);
            this.headerInfoCard.PerformLayout();
            this.headerTextPanel.ResumeLayout(false);
            this.headerTextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderLogo)).EndInit();
            this.projectCard.ResumeLayout(false);
            this.projectCard.PerformLayout();
            this.projectPathPanel.ResumeLayout(false);
            this.rulesCard.ResumeLayout(false);
            this.rulesCard.PerformLayout();
            this.rulesGrid.ResumeLayout(false);
            this.extensionsPanel.ResumeLayout(false);
            this.extensionsPanel.PerformLayout();
            this.extensionInputPanel.ResumeLayout(false);
            this.blockListColumn.ResumeLayout(false);
            this.blockListColumn.PerformLayout();
            this.blockListInputPanel.ResumeLayout(false);
            this.outputCard.ResumeLayout(false);
            this.outputCard.PerformLayout();
            this.outputContentPanel.ResumeLayout(false);
            this.outputPathPanel.ResumeLayout(false);
            this.statusCard.ResumeLayout(false);
            this.statusCard.PerformLayout();
            this.statusIconPanel.ResumeLayout(false);
            this.statusIconPanel.PerformLayout();
            this.statusButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.Panel headerPanel;
        private CardPanel headerInfoCard;
        private System.Windows.Forms.Label lblHeaderToolIcon;
        private System.Windows.Forms.Label lblHeaderToolTitle;
        private System.Windows.Forms.Label lblHeaderToolMeta;
        private System.Windows.Forms.Panel headerTextPanel;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picHeaderLogo;

        private CardPanel projectCard;
        private System.Windows.Forms.Label projectHeaderIcon;
        private System.Windows.Forms.Label projectHeaderTitle;
        private System.Windows.Forms.Label projectHeaderDescription;
        private System.Windows.Forms.Label lblProjectFolder;
        private CardPanel projectPathPanel;
        private System.Windows.Forms.TextBox txtProjectFolder;
        private RoundedButton btnBrowseProject;

        private CardPanel rulesCard;
        private System.Windows.Forms.Label rulesHeaderIcon;
        private System.Windows.Forms.Label rulesHeaderTitle;
        private System.Windows.Forms.Label rulesHeaderDescription;
        private System.Windows.Forms.TableLayoutPanel rulesGrid;
        private System.Windows.Forms.Panel extensionsPanel;
        private System.Windows.Forms.Label lblExtensions;
        private CardPanel extensionInputPanel;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label lblExtensionHint;
        private System.Windows.Forms.Panel blockListColumn;
        private System.Windows.Forms.Label lblBlockList;
        private CardPanel blockListInputPanel;
        private System.Windows.Forms.TextBox txtBlockList;
        private System.Windows.Forms.Label lblBlockListHint;

        private CardPanel outputCard;
        private System.Windows.Forms.Label outputHeaderIcon;
        private System.Windows.Forms.Label outputHeaderTitle;
        private System.Windows.Forms.Label outputHeaderDescription;
        private System.Windows.Forms.TableLayoutPanel outputContentPanel;
        private CardPanel outputPathPanel;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private RoundedButton btnBrowseOutput;
        private RoundedButton btnOpenOutput;

        private CardPanel statusCard;
        private System.Windows.Forms.Panel statusIconPanel;
        private System.Windows.Forms.Label lblStatusIcon;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusDetail;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.FlowLayoutPanel statusButtonsPanel;
        private RoundedButton btnProcess;
        private RoundedButton btnCancel;
    }
}
