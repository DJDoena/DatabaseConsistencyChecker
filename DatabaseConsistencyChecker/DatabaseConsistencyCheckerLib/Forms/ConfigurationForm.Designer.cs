namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.RuleListView = new System.Windows.Forms.ListView();
            this.CheckNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveRuleButton = new System.Windows.Forms.Button();
            this.EditRuleButton = new System.Windows.Forms.Button();
            this.AddRuleButton = new System.Windows.Forms.Button();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Location = new System.Drawing.Point(12, 9);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(176, 13);
            this.InfoLabel1.TabIndex = 0;
            this.InfoLabel1.Text = "Here you can edit the configuration.";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Location = new System.Drawing.Point(12, 29);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(218, 13);
            this.InfoLabel2.TabIndex = 1;
            this.InfoLabel2.Text = "A configuration consists of one or more rules.";
            // 
            // RuleListView
            // 
            this.RuleListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RuleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CheckNameColumn});
            this.RuleListView.FullRowSelect = true;
            this.RuleListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RuleListView.HideSelection = false;
            this.RuleListView.Location = new System.Drawing.Point(81, 49);
            this.RuleListView.Name = "RuleListView";
            this.RuleListView.Size = new System.Drawing.Size(560, 283);
            this.RuleListView.TabIndex = 3;
            this.RuleListView.UseCompatibleStateImageBehavior = false;
            this.RuleListView.View = System.Windows.Forms.View.Details;
            this.RuleListView.SelectedIndexChanged += new System.EventHandler(this.OnRuleListViewSelectedIndexChanged);
            // 
            // CheckNameColumn
            // 
            this.CheckNameColumn.Text = "Name";
            this.CheckNameColumn.Width = 250;
            // 
            // RemoveRuleButton
            // 
            this.RemoveRuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveRuleButton.Location = new System.Drawing.Point(647, 107);
            this.RemoveRuleButton.Name = "RemoveRuleButton";
            this.RemoveRuleButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveRuleButton.TabIndex = 6;
            this.RemoveRuleButton.Text = "Remove";
            this.RemoveRuleButton.UseVisualStyleBackColor = true;
            this.RemoveRuleButton.Click += new System.EventHandler(this.OnRemoveRuleButtonClick);
            // 
            // EditRuleButton
            // 
            this.EditRuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditRuleButton.Location = new System.Drawing.Point(647, 78);
            this.EditRuleButton.Name = "EditRuleButton";
            this.EditRuleButton.Size = new System.Drawing.Size(75, 23);
            this.EditRuleButton.TabIndex = 5;
            this.EditRuleButton.Text = "Edit";
            this.EditRuleButton.UseVisualStyleBackColor = true;
            this.EditRuleButton.Click += new System.EventHandler(this.OnEditRuleButtonClick);
            // 
            // AddRuleButton
            // 
            this.AddRuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRuleButton.Location = new System.Drawing.Point(647, 49);
            this.AddRuleButton.Name = "AddRuleButton";
            this.AddRuleButton.Size = new System.Drawing.Size(75, 23);
            this.AddRuleButton.TabIndex = 4;
            this.AddRuleButton.Text = "Add";
            this.AddRuleButton.UseVisualStyleBackColor = true;
            this.AddRuleButton.Click += new System.EventHandler(this.OnAddRuleButtonClick);
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Location = new System.Drawing.Point(12, 54);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(34, 13);
            this.CheckLabel.TabIndex = 2;
            this.CheckLabel.Text = "Rules";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 386);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.RemoveRuleButton);
            this.Controls.Add(this.EditRuleButton);
            this.Controls.Add(this.AddRuleButton);
            this.Controls.Add(this.RuleListView);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.InfoLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 425);
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.Controls.SetChildIndex(this.InfoLabel1, 0);
            this.Controls.SetChildIndex(this.InfoLabel2, 0);
            this.Controls.SetChildIndex(this.RuleListView, 0);
            this.Controls.SetChildIndex(this.AddRuleButton, 0);
            this.Controls.SetChildIndex(this.EditRuleButton, 0);
            this.Controls.SetChildIndex(this.RemoveRuleButton, 0);
            this.Controls.SetChildIndex(this.CheckLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.ListView RuleListView;
        private System.Windows.Forms.ColumnHeader CheckNameColumn;
        private System.Windows.Forms.Button RemoveRuleButton;
        private System.Windows.Forms.Button EditRuleButton;
        private System.Windows.Forms.Button AddRuleButton;
        private System.Windows.Forms.Label CheckLabel;
    }
}