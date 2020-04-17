namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class CheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForm));
            this.FilterTypeLabel = new System.Windows.Forms.Label();
            this.FilterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveFilterButton = new System.Windows.Forms.Button();
            this.EditFilterButton = new System.Windows.Forms.Button();
            this.AddFilterButton = new System.Windows.Forms.Button();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterListView = new System.Windows.Forms.ListView();
            this.FilterNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilterValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckNameTextBox = new System.Windows.Forms.TextBox();
            this.CheckNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilterTypeLabel
            // 
            this.FilterTypeLabel.AutoSize = true;
            this.FilterTypeLabel.Location = new System.Drawing.Point(12, 41);
            this.FilterTypeLabel.Name = "FilterTypeLabel";
            this.FilterTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.FilterTypeLabel.TabIndex = 2;
            this.FilterTypeLabel.Text = "Filter Type";
            // 
            // FilterTypeComboBox
            // 
            this.FilterTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterTypeComboBox.FormattingEnabled = true;
            this.FilterTypeComboBox.Location = new System.Drawing.Point(74, 38);
            this.FilterTypeComboBox.Name = "FilterTypeComboBox";
            this.FilterTypeComboBox.Size = new System.Drawing.Size(567, 21);
            this.FilterTypeComboBox.TabIndex = 3;
            // 
            // RemoveFilterButton
            // 
            this.RemoveFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFilterButton.Location = new System.Drawing.Point(647, 94);
            this.RemoveFilterButton.Name = "RemoveFilterButton";
            this.RemoveFilterButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveFilterButton.TabIndex = 8;
            this.RemoveFilterButton.Text = "Remove";
            this.RemoveFilterButton.UseVisualStyleBackColor = true;
            this.RemoveFilterButton.Click += new System.EventHandler(this.OnRemoveFilterButtonClick);
            // 
            // EditFilterButton
            // 
            this.EditFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFilterButton.Location = new System.Drawing.Point(647, 65);
            this.EditFilterButton.Name = "EditFilterButton";
            this.EditFilterButton.Size = new System.Drawing.Size(75, 23);
            this.EditFilterButton.TabIndex = 7;
            this.EditFilterButton.Text = "Edit";
            this.EditFilterButton.UseVisualStyleBackColor = true;
            this.EditFilterButton.Click += new System.EventHandler(this.OnEditFilterButtonClick);
            // 
            // AddFilterButton
            // 
            this.AddFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFilterButton.Location = new System.Drawing.Point(647, 36);
            this.AddFilterButton.Name = "AddFilterButton";
            this.AddFilterButton.Size = new System.Drawing.Size(75, 23);
            this.AddFilterButton.TabIndex = 4;
            this.AddFilterButton.Text = "Add";
            this.AddFilterButton.UseVisualStyleBackColor = true;
            this.AddFilterButton.Click += new System.EventHandler(this.OnAddFilterButtonClick);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(12, 70);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(29, 13);
            this.FilterLabel.TabIndex = 5;
            this.FilterLabel.Text = "Filter";
            // 
            // FilterListView
            // 
            this.FilterListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilterNameColumn,
            this.FilterValueColumn});
            this.FilterListView.FullRowSelect = true;
            this.FilterListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FilterListView.HideSelection = false;
            this.FilterListView.Location = new System.Drawing.Point(74, 65);
            this.FilterListView.Name = "FilterListView";
            this.FilterListView.Size = new System.Drawing.Size(567, 105);
            this.FilterListView.TabIndex = 6;
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
            // CheckNameTextBox
            // 
            this.CheckNameTextBox.Location = new System.Drawing.Point(74, 12);
            this.CheckNameTextBox.Name = "CheckNameTextBox";
            this.CheckNameTextBox.Size = new System.Drawing.Size(417, 20);
            this.CheckNameTextBox.TabIndex = 1;
            this.CheckNameTextBox.TextChanged += new System.EventHandler(this.OnCheckNameTextBoxTextChanged);
            // 
            // CheckNameLabel
            // 
            this.CheckNameLabel.AutoSize = true;
            this.CheckNameLabel.Location = new System.Drawing.Point(12, 15);
            this.CheckNameLabel.Name = "CheckNameLabel";
            this.CheckNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CheckNameLabel.TabIndex = 0;
            this.CheckNameLabel.Text = "Name";
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 211);
            this.Controls.Add(this.CheckNameLabel);
            this.Controls.Add(this.CheckNameTextBox);
            this.Controls.Add(this.FilterTypeLabel);
            this.Controls.Add(this.FilterTypeComboBox);
            this.Controls.Add(this.RemoveFilterButton);
            this.Controls.Add(this.EditFilterButton);
            this.Controls.Add(this.AddFilterButton);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 250);
            this.Name = "CheckForm";
            this.Text = "Check";
            this.Controls.SetChildIndex(this.FilterListView, 0);
            this.Controls.SetChildIndex(this.FilterLabel, 0);
            this.Controls.SetChildIndex(this.AddFilterButton, 0);
            this.Controls.SetChildIndex(this.EditFilterButton, 0);
            this.Controls.SetChildIndex(this.RemoveFilterButton, 0);
            this.Controls.SetChildIndex(this.FilterTypeComboBox, 0);
            this.Controls.SetChildIndex(this.FilterTypeLabel, 0);
            this.Controls.SetChildIndex(this.CheckNameTextBox, 0);
            this.Controls.SetChildIndex(this.CheckNameLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FilterTypeLabel;
        private System.Windows.Forms.ComboBox FilterTypeComboBox;
        private System.Windows.Forms.Button RemoveFilterButton;
        private System.Windows.Forms.Button EditFilterButton;
        private System.Windows.Forms.Button AddFilterButton;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.ListView FilterListView;
        private System.Windows.Forms.ColumnHeader FilterNameColumn;
        private System.Windows.Forms.ColumnHeader FilterValueColumn;
        private System.Windows.Forms.TextBox CheckNameTextBox;
        private System.Windows.Forms.Label CheckNameLabel;
    }
}