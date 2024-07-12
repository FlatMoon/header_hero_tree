using System.IO;
using System.Windows.Forms;

namespace HeaderHero
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.reportBrowser = new System.Windows.Forms.WebBrowser();
            this.includeTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.includesListView = new System.Windows.Forms.ListView();
            this.IncludesFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IncludesCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IncludesLines = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.includedByListView = new System.Windows.Forms.ListView();
            this.ByFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ByCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ByLines = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileColHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.fileListText = new System.Windows.Forms.TextBox();
            this.errorsTab = new System.Windows.Forms.TabPage();
            this.errorsListView = new System.Windows.Forms.ListView();
            this.missingTab = new System.Windows.Forms.TabPage();
            this.missingFilesListView = new System.Windows.Forms.ListView();
            this.treeTab = new System.Windows.Forms.TabPage();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnCreateTree = new System.Windows.Forms.Button();
            this.treeComboBox = new System.Windows.Forms.ComboBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPages.SuspendLayout();
            this.reportTab.SuspendLayout();
            this.includeTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.fileColHeader.SuspendLayout();
            this.errorsTab.SuspendLayout();
            this.missingTab.SuspendLayout();
            this.treeTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.reportTab);
            this.tabPages.Controls.Add(this.includeTab);
            this.tabPages.Controls.Add(this.errorsTab);
            this.tabPages.Controls.Add(this.missingTab);
            this.tabPages.Controls.Add(this.treeTab);
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Location = new System.Drawing.Point(0, 28);
            this.tabPages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(1233, 904);
            this.tabPages.TabIndex = 0;
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.reportBrowser);
            this.reportTab.Location = new System.Drawing.Point(4, 25);
            this.reportTab.Margin = new System.Windows.Forms.Padding(4);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(4);
            this.reportTab.Size = new System.Drawing.Size(1224, 1146);
            this.reportTab.TabIndex = 0;
            this.reportTab.Text = "Report";
            this.reportTab.UseVisualStyleBackColor = true;
            // 
            // reportBrowser
            // 
            this.reportBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportBrowser.Location = new System.Drawing.Point(4, 4);
            this.reportBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.reportBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.reportBrowser.Name = "reportBrowser";
            this.reportBrowser.Size = new System.Drawing.Size(1216, 1138);
            this.reportBrowser.TabIndex = 0;
            // 
            // includeTab
            // 
            this.includeTab.Controls.Add(this.tableLayoutPanel1);
            this.includeTab.Location = new System.Drawing.Point(4, 25);
            this.includeTab.Margin = new System.Windows.Forms.Padding(4);
            this.includeTab.Name = "includeTab";
            this.includeTab.Padding = new System.Windows.Forms.Padding(4);
            this.includeTab.Size = new System.Drawing.Size(1224, 1146);
            this.includeTab.TabIndex = 3;
            this.includeTab.Text = "Includes";
            this.includeTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.includesListView, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.includedByListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileColHeader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileListText, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1216, 1138);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // includesListView
            // 
            this.includesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IncludesFile,
            this.IncludesCount,
            this.IncludesLines});
            this.includesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.includesListView.HideSelection = false;
            this.includesListView.Location = new System.Drawing.Point(814, 29);
            this.includesListView.Margin = new System.Windows.Forms.Padding(4);
            this.includesListView.Name = "includesListView";
            this.includesListView.Size = new System.Drawing.Size(398, 1105);
            this.includesListView.TabIndex = 5;
            this.includesListView.UseCompatibleStateImageBehavior = false;
            this.includesListView.View = System.Windows.Forms.View.Details;
            // 
            // IncludesFile
            // 
            this.IncludesFile.Text = "File";
            this.IncludesFile.Width = 160;
            // 
            // IncludesCount
            // 
            this.IncludesCount.Text = "Count";
            this.IncludesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IncludesLines
            // 
            this.IncludesLines.Text = "Lines";
            this.IncludesLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(814, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Includes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Included by:";
            // 
            // includedByListView
            // 
            this.includedByListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ByFile,
            this.ByCount,
            this.ByLines});
            this.includedByListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.includedByListView.HideSelection = false;
            this.includedByListView.Location = new System.Drawing.Point(4, 29);
            this.includedByListView.Margin = new System.Windows.Forms.Padding(4);
            this.includedByListView.Name = "includedByListView";
            this.includedByListView.Size = new System.Drawing.Size(397, 1105);
            this.includedByListView.TabIndex = 3;
            this.includedByListView.UseCompatibleStateImageBehavior = false;
            this.includedByListView.View = System.Windows.Forms.View.Details;
            // 
            // ByFile
            // 
            this.ByFile.Text = "File";
            this.ByFile.Width = 160;
            // 
            // ByCount
            // 
            this.ByCount.Text = "Count";
            this.ByCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ByLines
            // 
            this.ByLines.Text = "Lines";
            this.ByLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileColHeader
            // 
            this.fileColHeader.ColumnCount = 2;
            this.fileColHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileColHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fileColHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.fileColHeader.Controls.Add(this.label2, 0, 0);
            this.fileColHeader.Controls.Add(this.btnBack, 1, 0);
            this.fileColHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileColHeader.Location = new System.Drawing.Point(405, 0);
            this.fileColHeader.Margin = new System.Windows.Forms.Padding(0);
            this.fileColHeader.Name = "fileColHeader";
            this.fileColHeader.RowCount = 1;
            this.fileColHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileColHeader.Size = new System.Drawing.Size(405, 25);
            this.fileColHeader.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "File:";
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(369, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 25);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fileListText
            // 
            this.fileListText.BackColor = System.Drawing.SystemColors.Window;
            this.fileListText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListText.Location = new System.Drawing.Point(409, 29);
            this.fileListText.Margin = new System.Windows.Forms.Padding(4);
            this.fileListText.Multiline = true;
            this.fileListText.Name = "fileListText";
            this.fileListText.ReadOnly = true;
            this.fileListText.Size = new System.Drawing.Size(397, 1105);
            this.fileListText.TabIndex = 7;
            // 
            // errorsTab
            // 
            this.errorsTab.Controls.Add(this.errorsListView);
            this.errorsTab.Location = new System.Drawing.Point(4, 25);
            this.errorsTab.Margin = new System.Windows.Forms.Padding(4);
            this.errorsTab.Name = "errorsTab";
            this.errorsTab.Padding = new System.Windows.Forms.Padding(4);
            this.errorsTab.Size = new System.Drawing.Size(1224, 1146);
            this.errorsTab.TabIndex = 1;
            this.errorsTab.Text = "Errors";
            this.errorsTab.UseVisualStyleBackColor = true;
            // 
            // errorsListView
            // 
            this.errorsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorsListView.HideSelection = false;
            this.errorsListView.Location = new System.Drawing.Point(4, 4);
            this.errorsListView.Margin = new System.Windows.Forms.Padding(4);
            this.errorsListView.Name = "errorsListView";
            this.errorsListView.Size = new System.Drawing.Size(1216, 1138);
            this.errorsListView.TabIndex = 0;
            this.errorsListView.UseCompatibleStateImageBehavior = false;
            this.errorsListView.View = System.Windows.Forms.View.List;
            // 
            // missingTab
            // 
            this.missingTab.Controls.Add(this.missingFilesListView);
            this.missingTab.Location = new System.Drawing.Point(4, 25);
            this.missingTab.Margin = new System.Windows.Forms.Padding(4);
            this.missingTab.Name = "missingTab";
            this.missingTab.Padding = new System.Windows.Forms.Padding(4);
            this.missingTab.Size = new System.Drawing.Size(1224, 1146);
            this.missingTab.TabIndex = 2;
            this.missingTab.Text = "Missing Files";
            this.missingTab.UseVisualStyleBackColor = true;
            // 
            // missingFilesListView
            // 
            this.missingFilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missingFilesListView.HideSelection = false;
            this.missingFilesListView.Location = new System.Drawing.Point(4, 4);
            this.missingFilesListView.Margin = new System.Windows.Forms.Padding(4);
            this.missingFilesListView.Name = "missingFilesListView";
            this.missingFilesListView.ShowItemToolTips = true;
            this.missingFilesListView.Size = new System.Drawing.Size(1216, 1138);
            this.missingFilesListView.TabIndex = 1;
            this.missingFilesListView.UseCompatibleStateImageBehavior = false;
            this.missingFilesListView.View = System.Windows.Forms.View.List;
            // 
            // treeTab
            // 
            this.treeTab.Controls.Add(this.LoadingLabel);
            this.treeTab.Controls.Add(this.btnExpandAll);
            this.treeTab.Controls.Add(this.btnCreateTree);
            this.treeTab.Controls.Add(this.treeComboBox);
            this.treeTab.Controls.Add(this.treeView);
            this.treeTab.Location = new System.Drawing.Point(4, 25);
            this.treeTab.Name = "treeTab";
            this.treeTab.Size = new System.Drawing.Size(1225, 875);
            this.treeTab.TabIndex = 4;
            this.treeTab.Text = "Tree View";
            this.treeTab.UseVisualStyleBackColor = true;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Location = new System.Drawing.Point(536, 293);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(91, 16);
            this.LoadingLabel.TabIndex = 5;
            this.LoadingLabel.Text = "Loading tree...";
            this.LoadingLabel.Visible = false;
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandAll.Location = new System.Drawing.Point(1091, 29);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(98, 25);
            this.btnExpandAll.TabIndex = 4;
            this.btnExpandAll.Text = "Expand All";
            this.btnExpandAll.UseVisualStyleBackColor = true;
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnCreateTree
            // 
            this.btnCreateTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTree.Location = new System.Drawing.Point(1089, -1);
            this.btnCreateTree.Name = "btnCreateTree";
            this.btnCreateTree.Size = new System.Drawing.Size(100, 24);
            this.btnCreateTree.TabIndex = 3;
            this.btnCreateTree.Text = "Create tree";
            this.btnCreateTree.UseVisualStyleBackColor = true;
            this.btnCreateTree.Click += new System.EventHandler(this.btnCreateTree_Click);
            // 
            // treeComboBox
            // 
            this.treeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.treeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.treeComboBox.DisplayMember = "VALUE";
            this.treeComboBox.FormattingEnabled = true;
            this.treeComboBox.Location = new System.Drawing.Point(0, 0);
            this.treeComboBox.Name = "treeComboBox";
            this.treeComboBox.Size = new System.Drawing.Size(1082, 24);
            this.treeComboBox.TabIndex = 2;
            this.treeComboBox.ValueMember = "ID";
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(-4, 20);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(1226, 859);
            this.treeView.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1233, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rescanToolStripMenuItem});
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.scanToolStripMenuItem.Text = "Scan";
            // 
            // rescanToolStripMenuItem
            // 
            this.rescanToolStripMenuItem.Name = "rescanToolStripMenuItem";
            this.rescanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rescanToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.rescanToolStripMenuItem.Text = "Rescan";
            this.rescanToolStripMenuItem.Click += new System.EventHandler(this.rescanToolStripMenuItem_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 932);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.Text = "Report";
            this.tabPages.ResumeLayout(false);
            this.reportTab.ResumeLayout(false);
            this.includeTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.fileColHeader.ResumeLayout(false);
            this.fileColHeader.PerformLayout();
            this.errorsTab.ResumeLayout(false);
            this.missingTab.ResumeLayout(false);
            this.treeTab.ResumeLayout(false);
            this.treeTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.TabPage errorsTab;
        private System.Windows.Forms.TabPage missingTab;
        private System.Windows.Forms.ListView errorsListView;
        private System.Windows.Forms.ListView missingFilesListView;
        private System.Windows.Forms.TabPage includeTab;
        private System.Windows.Forms.WebBrowser reportBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView includesListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView includedByListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescanToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ByFile;
        private System.Windows.Forms.ColumnHeader ByCount;
        private System.Windows.Forms.ColumnHeader ByLines;
        private System.Windows.Forms.ColumnHeader IncludesFile;
        private System.Windows.Forms.ColumnHeader IncludesCount;
        private System.Windows.Forms.ColumnHeader IncludesLines;
        private System.Windows.Forms.TableLayoutPanel fileColHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox fileListText;
        private System.Windows.Forms.TabPage treeTab;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ComboBox treeComboBox;
        private Button btnCreateTree;
        private Button btnExpandAll;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Label LoadingLabel;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}