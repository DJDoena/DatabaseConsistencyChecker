namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CollectionFileTextBox = new System.Windows.Forms.TextBox();
            this.ConfigurationFileTextBox = new System.Windows.Forms.TextBox();
            this.LoadCollectionButton = new System.Windows.Forms.Button();
            this.LoadConfigurationButton = new System.Windows.Forms.Button();
            this.NewConfigurationButton = new System.Windows.Forms.Button();
            this.RunChecksButton = new System.Windows.Forms.Button();
            this.CollectionFileLabel = new System.Windows.Forms.Label();
            this.ConfigurationFileLabel = new System.Windows.Forms.Label();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.RuleNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProfileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckResultLabel = new System.Windows.Forms.Label();
            this.ExportFlagSetButton = new System.Windows.Forms.Button();
            this.EditConfigurationButton = new System.Windows.Forms.Button();
            this.SaveConfigurationButton = new System.Windows.Forms.Button();
            this.RootMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfilesLoadedLabel = new System.Windows.Forms.Label();
            this.RulesLoadedLabel = new System.Windows.Forms.Label();
            this.RootMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CollectionFileTextBox
            // 
            this.CollectionFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectionFileTextBox.Location = new System.Drawing.Point(103, 29);
            this.CollectionFileTextBox.Name = "CollectionFileTextBox";
            this.CollectionFileTextBox.ReadOnly = true;
            this.CollectionFileTextBox.Size = new System.Drawing.Size(638, 20);
            this.CollectionFileTextBox.TabIndex = 2;
            // 
            // ConfigurationFileTextBox
            // 
            this.ConfigurationFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigurationFileTextBox.Location = new System.Drawing.Point(103, 58);
            this.ConfigurationFileTextBox.Name = "ConfigurationFileTextBox";
            this.ConfigurationFileTextBox.ReadOnly = true;
            this.ConfigurationFileTextBox.Size = new System.Drawing.Size(638, 20);
            this.ConfigurationFileTextBox.TabIndex = 5;
            // 
            // LoadCollectionButton
            // 
            this.LoadCollectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadCollectionButton.Location = new System.Drawing.Point(747, 27);
            this.LoadCollectionButton.Name = "LoadCollectionButton";
            this.LoadCollectionButton.Size = new System.Drawing.Size(125, 23);
            this.LoadCollectionButton.TabIndex = 3;
            this.LoadCollectionButton.Text = "Load collection";
            this.LoadCollectionButton.UseVisualStyleBackColor = true;
            this.LoadCollectionButton.Click += new System.EventHandler(this.OnLoadCollectionButtonClick);
            // 
            // LoadConfigurationButton
            // 
            this.LoadConfigurationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadConfigurationButton.Location = new System.Drawing.Point(747, 56);
            this.LoadConfigurationButton.Name = "LoadConfigurationButton";
            this.LoadConfigurationButton.Size = new System.Drawing.Size(125, 23);
            this.LoadConfigurationButton.TabIndex = 6;
            this.LoadConfigurationButton.Text = "Load configuration";
            this.LoadConfigurationButton.UseVisualStyleBackColor = true;
            this.LoadConfigurationButton.Click += new System.EventHandler(this.OnLoadConfigurationButtonClick);
            // 
            // NewConfigurationButton
            // 
            this.NewConfigurationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewConfigurationButton.Location = new System.Drawing.Point(747, 114);
            this.NewConfigurationButton.Name = "NewConfigurationButton";
            this.NewConfigurationButton.Size = new System.Drawing.Size(125, 23);
            this.NewConfigurationButton.TabIndex = 10;
            this.NewConfigurationButton.Text = "New configuration";
            this.NewConfigurationButton.UseVisualStyleBackColor = true;
            this.NewConfigurationButton.Click += new System.EventHandler(this.OnNewConfigurationButtonClick);
            // 
            // RunChecksButton
            // 
            this.RunChecksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RunChecksButton.Location = new System.Drawing.Point(747, 200);
            this.RunChecksButton.Name = "RunChecksButton";
            this.RunChecksButton.Size = new System.Drawing.Size(125, 23);
            this.RunChecksButton.TabIndex = 14;
            this.RunChecksButton.Text = "Run checks";
            this.RunChecksButton.UseVisualStyleBackColor = true;
            this.RunChecksButton.Click += new System.EventHandler(this.OnRunChecksButtonClick);
            // 
            // CollectionFileLabel
            // 
            this.CollectionFileLabel.AutoSize = true;
            this.CollectionFileLabel.Location = new System.Drawing.Point(12, 32);
            this.CollectionFileLabel.Name = "CollectionFileLabel";
            this.CollectionFileLabel.Size = new System.Drawing.Size(69, 13);
            this.CollectionFileLabel.TabIndex = 1;
            this.CollectionFileLabel.Text = "Collection file";
            // 
            // ConfigurationFileLabel
            // 
            this.ConfigurationFileLabel.AutoSize = true;
            this.ConfigurationFileLabel.Location = new System.Drawing.Point(12, 61);
            this.ConfigurationFileLabel.Name = "ConfigurationFileLabel";
            this.ConfigurationFileLabel.Size = new System.Drawing.Size(85, 13);
            this.ConfigurationFileLabel.TabIndex = 4;
            this.ConfigurationFileLabel.Text = "Configuration file";
            // 
            // ResultListView
            // 
            this.ResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RuleNameColumn,
            this.CheckNameColumn,
            this.ProfileColumn});
            this.ResultListView.FullRowSelect = true;
            this.ResultListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(103, 200);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(638, 249);
            this.ResultListView.TabIndex = 13;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // RuleNameColumn
            // 
            this.RuleNameColumn.Text = "Rule name";
            this.RuleNameColumn.Width = 150;
            // 
            // CheckNameColumn
            // 
            this.CheckNameColumn.Text = "Check name";
            this.CheckNameColumn.Width = 150;
            // 
            // ProfileColumn
            // 
            this.ProfileColumn.Text = "Profile";
            this.ProfileColumn.Width = 300;
            // 
            // CheckResultLabel
            // 
            this.CheckResultLabel.AutoSize = true;
            this.CheckResultLabel.Location = new System.Drawing.Point(12, 205);
            this.CheckResultLabel.Name = "CheckResultLabel";
            this.CheckResultLabel.Size = new System.Drawing.Size(71, 13);
            this.CheckResultLabel.TabIndex = 12;
            this.CheckResultLabel.Text = "Check results";
            // 
            // ExportFlagSetButton
            // 
            this.ExportFlagSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportFlagSetButton.Location = new System.Drawing.Point(747, 426);
            this.ExportFlagSetButton.Name = "ExportFlagSetButton";
            this.ExportFlagSetButton.Size = new System.Drawing.Size(125, 23);
            this.ExportFlagSetButton.TabIndex = 15;
            this.ExportFlagSetButton.Text = "Export flag set";
            this.ExportFlagSetButton.UseVisualStyleBackColor = true;
            this.ExportFlagSetButton.Click += new System.EventHandler(this.OnExportFlagSetButtonClick);
            // 
            // EditConfigurationButton
            // 
            this.EditConfigurationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditConfigurationButton.Location = new System.Drawing.Point(747, 85);
            this.EditConfigurationButton.Name = "EditConfigurationButton";
            this.EditConfigurationButton.Size = new System.Drawing.Size(125, 23);
            this.EditConfigurationButton.TabIndex = 8;
            this.EditConfigurationButton.Text = "Edit configuration";
            this.EditConfigurationButton.UseVisualStyleBackColor = true;
            this.EditConfigurationButton.Click += new System.EventHandler(this.OnEditConfigurationButtonClick);
            // 
            // SaveConfigurationButton
            // 
            this.SaveConfigurationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveConfigurationButton.Location = new System.Drawing.Point(747, 143);
            this.SaveConfigurationButton.Name = "SaveConfigurationButton";
            this.SaveConfigurationButton.Size = new System.Drawing.Size(125, 23);
            this.SaveConfigurationButton.TabIndex = 11;
            this.SaveConfigurationButton.Text = "Save configuration as";
            this.SaveConfigurationButton.UseVisualStyleBackColor = true;
            this.SaveConfigurationButton.Click += new System.EventHandler(this.OnSaveConfigurationButtonClick);
            // 
            // RootMenuStrip
            // 
            this.RootMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.RootMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.RootMenuStrip.Name = "RootMenuStrip";
            this.RootMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.RootMenuStrip.TabIndex = 0;
            this.RootMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ExitToolStripMenuItem.Text = "&Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckForUpdatesToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // CheckForUpdatesToolStripMenuItem
            // 
            this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
            this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.CheckForUpdatesToolStripMenuItem.Text = "&Check for Updates";
            this.CheckForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.OnCheckForUpdatesToolStripMenuItemClick);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // ProfilesLoadedLabel
            // 
            this.ProfilesLoadedLabel.AutoSize = true;
            this.ProfilesLoadedLabel.Location = new System.Drawing.Point(100, 90);
            this.ProfilesLoadedLabel.Name = "ProfilesLoadedLabel";
            this.ProfilesLoadedLabel.Size = new System.Drawing.Size(0, 13);
            this.ProfilesLoadedLabel.TabIndex = 7;
            // 
            // RulesLoadedLabel
            // 
            this.RulesLoadedLabel.AutoSize = true;
            this.RulesLoadedLabel.Location = new System.Drawing.Point(100, 119);
            this.RulesLoadedLabel.Name = "RulesLoadedLabel";
            this.RulesLoadedLabel.Size = new System.Drawing.Size(0, 13);
            this.RulesLoadedLabel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.RulesLoadedLabel);
            this.Controls.Add(this.ProfilesLoadedLabel);
            this.Controls.Add(this.SaveConfigurationButton);
            this.Controls.Add(this.EditConfigurationButton);
            this.Controls.Add(this.ExportFlagSetButton);
            this.Controls.Add(this.CheckResultLabel);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.ConfigurationFileLabel);
            this.Controls.Add(this.CollectionFileLabel);
            this.Controls.Add(this.RunChecksButton);
            this.Controls.Add(this.NewConfigurationButton);
            this.Controls.Add(this.LoadConfigurationButton);
            this.Controls.Add(this.LoadCollectionButton);
            this.Controls.Add(this.ConfigurationFileTextBox);
            this.Controls.Add(this.CollectionFileTextBox);
            this.Controls.Add(this.RootMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.Text = "Database Consistency Checker";
            this.RootMenuStrip.ResumeLayout(false);
            this.RootMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CollectionFileTextBox;
        private System.Windows.Forms.TextBox ConfigurationFileTextBox;
        private System.Windows.Forms.Button LoadCollectionButton;
        private System.Windows.Forms.Button LoadConfigurationButton;
        private System.Windows.Forms.Button NewConfigurationButton;
        private System.Windows.Forms.Button RunChecksButton;
        private System.Windows.Forms.Label CollectionFileLabel;
        private System.Windows.Forms.Label ConfigurationFileLabel;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.ColumnHeader RuleNameColumn;
        private System.Windows.Forms.ColumnHeader CheckNameColumn;
        private System.Windows.Forms.Label CheckResultLabel;
        private System.Windows.Forms.Button ExportFlagSetButton;
        private System.Windows.Forms.ColumnHeader ProfileColumn;
        private System.Windows.Forms.Button EditConfigurationButton;
        private System.Windows.Forms.Button SaveConfigurationButton;
        private System.Windows.Forms.MenuStrip RootMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label ProfilesLoadedLabel;
        private System.Windows.Forms.Label RulesLoadedLabel;
    }
}