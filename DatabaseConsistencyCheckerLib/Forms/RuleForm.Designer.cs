namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class RuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleForm));
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.InfoLabel3 = new System.Windows.Forms.Label();
            this.InfoLabel4 = new System.Windows.Forms.Label();
            this.InfoLabel5 = new System.Windows.Forms.Label();
            this.RuleNameTextBox = new System.Windows.Forms.TextBox();
            this.RuleNameLabel = new System.Windows.Forms.Label();
            this.FilterListView = new System.Windows.Forms.ListView();
            this.FilterNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilterValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilterLabel = new System.Windows.Forms.Label();
            this.AddFilterButton = new System.Windows.Forms.Button();
            this.EditFilterButton = new System.Windows.Forms.Button();
            this.RemoveFilterButton = new System.Windows.Forms.Button();
            this.CheckListView = new System.Windows.Forms.ListView();
            this.CheckNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveCheckButton = new System.Windows.Forms.Button();
            this.EditCheckButton = new System.Windows.Forms.Button();
            this.AddCheckButton = new System.Windows.Forms.Button();
            this.FilterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.FilterTypeLabel = new System.Windows.Forms.Label();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Location = new System.Drawing.Point(12, 9);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(123, 13);
            this.InfoLabel1.TabIndex = 0;
            this.InfoLabel1.Text = "Here you can edit a rule.";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Location = new System.Drawing.Point(12, 29);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(143, 13);
            this.InfoLabel2.TabIndex = 1;
            this.InfoLabel2.Text = "A rule consists of three parts:";
            // 
            // InfoLabel3
            // 
            this.InfoLabel3.AutoSize = true;
            this.InfoLabel3.Location = new System.Drawing.Point(12, 49);
            this.InfoLabel3.Name = "InfoLabel3";
            this.InfoLabel3.Size = new System.Drawing.Size(107, 13);
            this.InfoLabel3.TabIndex = 2;
            this.InfoLabel3.Text = "- A name (mandatory)";
            // 
            // InfoLabel4
            // 
            this.InfoLabel4.AutoSize = true;
            this.InfoLabel4.Location = new System.Drawing.Point(12, 69);
            this.InfoLabel4.Name = "InfoLabel4";
            this.InfoLabel4.Size = new System.Drawing.Size(430, 13);
            this.InfoLabel4.TabIndex = 3;
            this.InfoLabel4.Text = "- A filter to be applied on the collection so that only relevant profiles are che" +
    "cked (optional)";
            // 
            // InfoLabel5
            // 
            this.InfoLabel5.AutoSize = true;
            this.InfoLabel5.Location = new System.Drawing.Point(12, 89);
            this.InfoLabel5.Name = "InfoLabel5";
            this.InfoLabel5.Size = new System.Drawing.Size(246, 13);
            this.InfoLabel5.TabIndex = 4;
            this.InfoLabel5.Text = "- A list of checks to be run (at least one mandatory)";
            // 
            // RuleNameTextBox
            // 
            this.RuleNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RuleNameTextBox.Location = new System.Drawing.Point(81, 120);
            this.RuleNameTextBox.Name = "RuleNameTextBox";
            this.RuleNameTextBox.Size = new System.Drawing.Size(499, 20);
            this.RuleNameTextBox.TabIndex = 6;
            // 
            // RuleNameLabel
            // 
            this.RuleNameLabel.AutoSize = true;
            this.RuleNameLabel.Location = new System.Drawing.Point(12, 123);
            this.RuleNameLabel.Name = "RuleNameLabel";
            this.RuleNameLabel.Size = new System.Drawing.Size(60, 13);
            this.RuleNameLabel.TabIndex = 5;
            this.RuleNameLabel.Text = "Rule Name";
            // 
            // FilterListView
            // 
            this.FilterListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilterNameColumn,
            this.FilterValueColumn});
            this.FilterListView.FullRowSelect = true;
            this.FilterListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FilterListView.HideSelection = false;
            this.FilterListView.Location = new System.Drawing.Point(81, 175);
            this.FilterListView.Name = "FilterListView";
            this.FilterListView.Size = new System.Drawing.Size(418, 81);
            this.FilterListView.TabIndex = 11;
            this.FilterListView.UseCompatibleStateImageBehavior = false;
            this.FilterListView.View = System.Windows.Forms.View.Details;
            this.FilterListView.SelectedIndexChanged += new System.EventHandler(this.OnFilterListViewSelectedIndexChanged);
            // 
            // FilterNameColumn
            // 
            this.FilterNameColumn.Text = "Name";
            this.FilterNameColumn.Width = 250;
            // 
            // FilterValueColumn
            // 
            this.FilterValueColumn.Text = "Value";
            this.FilterValueColumn.Width = 150;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(12, 180);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(29, 13);
            this.FilterLabel.TabIndex = 10;
            this.FilterLabel.Text = "Filter";
            // 
            // AddFilterButton
            // 
            this.AddFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFilterButton.Location = new System.Drawing.Point(505, 146);
            this.AddFilterButton.Name = "AddFilterButton";
            this.AddFilterButton.Size = new System.Drawing.Size(75, 23);
            this.AddFilterButton.TabIndex = 9;
            this.AddFilterButton.Text = "Add";
            this.AddFilterButton.UseVisualStyleBackColor = true;
            this.AddFilterButton.Click += new System.EventHandler(this.OnAddFilterButtonClick);
            // 
            // EditFilterButton
            // 
            this.EditFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFilterButton.Location = new System.Drawing.Point(505, 175);
            this.EditFilterButton.Name = "EditFilterButton";
            this.EditFilterButton.Size = new System.Drawing.Size(75, 23);
            this.EditFilterButton.TabIndex = 12;
            this.EditFilterButton.Text = "Edit";
            this.EditFilterButton.UseVisualStyleBackColor = true;
            this.EditFilterButton.Click += new System.EventHandler(this.OnEditFilterButtonClick);
            // 
            // RemoveFilterButton
            // 
            this.RemoveFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFilterButton.Location = new System.Drawing.Point(505, 204);
            this.RemoveFilterButton.Name = "RemoveFilterButton";
            this.RemoveFilterButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveFilterButton.TabIndex = 13;
            this.RemoveFilterButton.Text = "Remove";
            this.RemoveFilterButton.UseVisualStyleBackColor = true;
            this.RemoveFilterButton.Click += new System.EventHandler(this.OnRemoveFilterButtonClick);
            // 
            // CheckListView
            // 
            this.CheckListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CheckNameColumn});
            this.CheckListView.FullRowSelect = true;
            this.CheckListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CheckListView.HideSelection = false;
            this.CheckListView.Location = new System.Drawing.Point(81, 262);
            this.CheckListView.Name = "CheckListView";
            this.CheckListView.Size = new System.Drawing.Size(418, 83);
            this.CheckListView.TabIndex = 15;
            this.CheckListView.UseCompatibleStateImageBehavior = false;
            this.CheckListView.View = System.Windows.Forms.View.Details;
            this.CheckListView.SelectedIndexChanged += new System.EventHandler(this.OnCheckListViewSelectedIndexChanged);
            // 
            // CheckNameColumn
            // 
            this.CheckNameColumn.Text = "Name";
            this.CheckNameColumn.Width = 250;
            // 
            // RemoveCheckButton
            // 
            this.RemoveCheckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveCheckButton.Location = new System.Drawing.Point(505, 320);
            this.RemoveCheckButton.Name = "RemoveCheckButton";
            this.RemoveCheckButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveCheckButton.TabIndex = 18;
            this.RemoveCheckButton.Text = "Remove";
            this.RemoveCheckButton.UseVisualStyleBackColor = true;
            this.RemoveCheckButton.Click += new System.EventHandler(this.OnRemoveCheckButtonClick);
            // 
            // EditCheckButton
            // 
            this.EditCheckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditCheckButton.Location = new System.Drawing.Point(505, 291);
            this.EditCheckButton.Name = "EditCheckButton";
            this.EditCheckButton.Size = new System.Drawing.Size(75, 23);
            this.EditCheckButton.TabIndex = 17;
            this.EditCheckButton.Text = "Edit";
            this.EditCheckButton.UseVisualStyleBackColor = true;
            this.EditCheckButton.Click += new System.EventHandler(this.OnEditCheckButtonClick);
            // 
            // AddCheckButton
            // 
            this.AddCheckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCheckButton.Location = new System.Drawing.Point(505, 262);
            this.AddCheckButton.Name = "AddCheckButton";
            this.AddCheckButton.Size = new System.Drawing.Size(75, 23);
            this.AddCheckButton.TabIndex = 16;
            this.AddCheckButton.Text = "Add";
            this.AddCheckButton.UseVisualStyleBackColor = true;
            this.AddCheckButton.Click += new System.EventHandler(this.OnAddCheckButtonClick);
            // 
            // FilterTypeComboBox
            // 
            this.FilterTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterTypeComboBox.FormattingEnabled = true;
            this.FilterTypeComboBox.Location = new System.Drawing.Point(81, 148);
            this.FilterTypeComboBox.Name = "FilterTypeComboBox";
            this.FilterTypeComboBox.Size = new System.Drawing.Size(418, 21);
            this.FilterTypeComboBox.TabIndex = 8;
            // 
            // FilterTypeLabel
            // 
            this.FilterTypeLabel.AutoSize = true;
            this.FilterTypeLabel.Location = new System.Drawing.Point(12, 151);
            this.FilterTypeLabel.Name = "FilterTypeLabel";
            this.FilterTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.FilterTypeLabel.TabIndex = 7;
            this.FilterTypeLabel.Text = "Filter Type";
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Location = new System.Drawing.Point(12, 267);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(43, 13);
            this.CheckLabel.TabIndex = 14;
            this.CheckLabel.Text = "Checks";
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 386);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.FilterTypeLabel);
            this.Controls.Add(this.FilterTypeComboBox);
            this.Controls.Add(this.RemoveCheckButton);
            this.Controls.Add(this.EditCheckButton);
            this.Controls.Add(this.AddCheckButton);
            this.Controls.Add(this.CheckListView);
            this.Controls.Add(this.RemoveFilterButton);
            this.Controls.Add(this.EditFilterButton);
            this.Controls.Add(this.AddFilterButton);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterListView);
            this.Controls.Add(this.RuleNameLabel);
            this.Controls.Add(this.RuleNameTextBox);
            this.Controls.Add(this.InfoLabel5);
            this.Controls.Add(this.InfoLabel4);
            this.Controls.Add(this.InfoLabel3);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.InfoLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 425);
            this.Name = "RuleForm";
            this.Text = "Rule";
            this.Controls.SetChildIndex(this.InfoLabel1, 0);
            this.Controls.SetChildIndex(this.InfoLabel2, 0);
            this.Controls.SetChildIndex(this.InfoLabel3, 0);
            this.Controls.SetChildIndex(this.InfoLabel4, 0);
            this.Controls.SetChildIndex(this.InfoLabel5, 0);
            this.Controls.SetChildIndex(this.RuleNameTextBox, 0);
            this.Controls.SetChildIndex(this.RuleNameLabel, 0);
            this.Controls.SetChildIndex(this.FilterListView, 0);
            this.Controls.SetChildIndex(this.FilterLabel, 0);
            this.Controls.SetChildIndex(this.AddFilterButton, 0);
            this.Controls.SetChildIndex(this.EditFilterButton, 0);
            this.Controls.SetChildIndex(this.RemoveFilterButton, 0);
            this.Controls.SetChildIndex(this.CheckListView, 0);
            this.Controls.SetChildIndex(this.AddCheckButton, 0);
            this.Controls.SetChildIndex(this.EditCheckButton, 0);
            this.Controls.SetChildIndex(this.RemoveCheckButton, 0);
            this.Controls.SetChildIndex(this.FilterTypeComboBox, 0);
            this.Controls.SetChildIndex(this.FilterTypeLabel, 0);
            this.Controls.SetChildIndex(this.CheckLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.Label InfoLabel3;
        private System.Windows.Forms.Label InfoLabel4;
        private System.Windows.Forms.Label InfoLabel5;
        private System.Windows.Forms.TextBox RuleNameTextBox;
        private System.Windows.Forms.Label RuleNameLabel;
        private System.Windows.Forms.ListView FilterListView;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Button AddFilterButton;
        private System.Windows.Forms.Button EditFilterButton;
        private System.Windows.Forms.Button RemoveFilterButton;
        private System.Windows.Forms.ColumnHeader FilterNameColumn;
        private System.Windows.Forms.ColumnHeader FilterValueColumn;
        private System.Windows.Forms.ListView CheckListView;
        private System.Windows.Forms.ColumnHeader CheckNameColumn;
        private System.Windows.Forms.Button RemoveCheckButton;
        private System.Windows.Forms.Button EditCheckButton;
        private System.Windows.Forms.Button AddCheckButton;
        private System.Windows.Forms.ComboBox FilterTypeComboBox;
        private System.Windows.Forms.Label FilterTypeLabel;
        private System.Windows.Forms.Label CheckLabel;
    }
}