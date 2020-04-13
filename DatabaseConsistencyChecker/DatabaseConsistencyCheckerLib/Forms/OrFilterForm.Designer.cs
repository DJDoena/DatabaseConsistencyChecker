namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class OrFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrFilterForm));
            this.FilterDescriptionLabel = new System.Windows.Forms.Label();
            this.FilterTypeLabel = new System.Windows.Forms.Label();
            this.FilterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveFilterButton = new System.Windows.Forms.Button();
            this.EditFilterButton = new System.Windows.Forms.Button();
            this.AddFilterButton = new System.Windows.Forms.Button();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterListView = new System.Windows.Forms.ListView();
            this.FilterNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilterValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // FilterDescriptionLabel
            // 
            this.FilterDescriptionLabel.AutoSize = true;
            this.FilterDescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.FilterDescriptionLabel.Name = "FilterDescriptionLabel";
            this.FilterDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            this.FilterDescriptionLabel.TabIndex = 0;
            this.FilterDescriptionLabel.Text = "Filter Description";
            // 
            // FilterTypeLabel
            // 
            this.FilterTypeLabel.AutoSize = true;
            this.FilterTypeLabel.Location = new System.Drawing.Point(12, 28);
            this.FilterTypeLabel.Name = "FilterTypeLabel";
            this.FilterTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.FilterTypeLabel.TabIndex = 1;
            this.FilterTypeLabel.Text = "Filter Type";
            // 
            // FilterTypeComboBox
            // 
            this.FilterTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterTypeComboBox.FormattingEnabled = true;
            this.FilterTypeComboBox.Location = new System.Drawing.Point(74, 25);
            this.FilterTypeComboBox.Name = "FilterTypeComboBox";
            this.FilterTypeComboBox.Size = new System.Drawing.Size(417, 21);
            this.FilterTypeComboBox.TabIndex = 2;
            // 
            // RemoveFilterButton
            // 
            this.RemoveFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFilterButton.Location = new System.Drawing.Point(497, 83);
            this.RemoveFilterButton.Name = "RemoveFilterButton";
            this.RemoveFilterButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveFilterButton.TabIndex = 7;
            this.RemoveFilterButton.Text = "Remove";
            this.RemoveFilterButton.UseVisualStyleBackColor = true;
            this.RemoveFilterButton.Click += new System.EventHandler(this.OnRemoveFilterButtonClick);
            // 
            // EditFilterButton
            // 
            this.EditFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFilterButton.Location = new System.Drawing.Point(497, 54);
            this.EditFilterButton.Name = "EditFilterButton";
            this.EditFilterButton.Size = new System.Drawing.Size(75, 23);
            this.EditFilterButton.TabIndex = 6;
            this.EditFilterButton.Text = "Edit";
            this.EditFilterButton.UseVisualStyleBackColor = true;
            this.EditFilterButton.Click += new System.EventHandler(this.OnEditFilterButtonClick);
            // 
            // AddFilterButton
            // 
            this.AddFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFilterButton.Location = new System.Drawing.Point(497, 25);
            this.AddFilterButton.Name = "AddFilterButton";
            this.AddFilterButton.Size = new System.Drawing.Size(75, 23);
            this.AddFilterButton.TabIndex = 3;
            this.AddFilterButton.Text = "Add";
            this.AddFilterButton.UseVisualStyleBackColor = true;
            this.AddFilterButton.Click += new System.EventHandler(this.OnAddFilterButtonClick);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(12, 59);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(29, 13);
            this.FilterLabel.TabIndex = 4;
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
            this.FilterListView.Location = new System.Drawing.Point(74, 54);
            this.FilterListView.Name = "FilterListView";
            this.FilterListView.Size = new System.Drawing.Size(417, 116);
            this.FilterListView.TabIndex = 5;
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
            // OrFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.FilterTypeLabel);
            this.Controls.Add(this.FilterTypeComboBox);
            this.Controls.Add(this.RemoveFilterButton);
            this.Controls.Add(this.EditFilterButton);
            this.Controls.Add(this.AddFilterButton);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterListView);
            this.Controls.Add(this.FilterDescriptionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "OrFilterForm";
            this.Text = "OR Filter";
            this.Controls.SetChildIndex(this.FilterDescriptionLabel, 0);
            this.Controls.SetChildIndex(this.FilterListView, 0);
            this.Controls.SetChildIndex(this.FilterLabel, 0);
            this.Controls.SetChildIndex(this.AddFilterButton, 0);
            this.Controls.SetChildIndex(this.EditFilterButton, 0);
            this.Controls.SetChildIndex(this.RemoveFilterButton, 0);
            this.Controls.SetChildIndex(this.FilterTypeComboBox, 0);
            this.Controls.SetChildIndex(this.FilterTypeLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FilterDescriptionLabel;
        private System.Windows.Forms.Label FilterTypeLabel;
        private System.Windows.Forms.ComboBox FilterTypeComboBox;
        private System.Windows.Forms.Button RemoveFilterButton;
        private System.Windows.Forms.Button EditFilterButton;
        private System.Windows.Forms.Button AddFilterButton;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.ListView FilterListView;
        private System.Windows.Forms.ColumnHeader FilterNameColumn;
        private System.Windows.Forms.ColumnHeader FilterValueColumn;
    }
}