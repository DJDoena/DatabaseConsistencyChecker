namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class EventFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventFilterForm));
            this.EventTypeLabel = new System.Windows.Forms.Label();
            this.EventTypeComboBox = new System.Windows.Forms.ComboBox();
            this.FilterDescriptionLabel = new System.Windows.Forms.Label();
            this.UserFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.UserLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChoiceInfoLabel = new System.Windows.Forms.Label();
            this.ChoiceLabel = new System.Windows.Forms.Label();
            this.ChoiceCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EventTypeLabel
            // 
            this.EventTypeLabel.AutoSize = true;
            this.EventTypeLabel.Location = new System.Drawing.Point(12, 52);
            this.EventTypeLabel.Name = "EventTypeLabel";
            this.EventTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.EventTypeLabel.TabIndex = 4;
            this.EventTypeLabel.Text = "Filter Type";
            // 
            // EventTypeComboBox
            // 
            this.EventTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventTypeComboBox.FormattingEnabled = true;
            this.EventTypeComboBox.Location = new System.Drawing.Point(95, 49);
            this.EventTypeComboBox.Name = "EventTypeComboBox";
            this.EventTypeComboBox.Size = new System.Drawing.Size(627, 21);
            this.EventTypeComboBox.TabIndex = 5;
            this.EventTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnEventTypeComboBoxSelectedIndexChanged);
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
            // UserFirstNameTextBox
            // 
            this.UserFirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserFirstNameTextBox.Location = new System.Drawing.Point(95, 76);
            this.UserFirstNameTextBox.Name = "UserFirstNameTextBox";
            this.UserFirstNameTextBox.Size = new System.Drawing.Size(627, 20);
            this.UserFirstNameTextBox.TabIndex = 7;
            this.UserFirstNameTextBox.TextChanged += new System.EventHandler(this.OnUserFirstNameTextBoxTextChanged);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(12, 79);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(77, 13);
            this.ValueLabel.TabIndex = 6;
            this.ValueLabel.Text = "User first name";
            // 
            // UserLastNameTextBox
            // 
            this.UserLastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLastNameTextBox.Location = new System.Drawing.Point(95, 102);
            this.UserLastNameTextBox.Name = "UserLastNameTextBox";
            this.UserLastNameTextBox.Size = new System.Drawing.Size(627, 20);
            this.UserLastNameTextBox.TabIndex = 9;
            this.UserLastNameTextBox.TextChanged += new System.EventHandler(this.OnUserLastNameTextBoxTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User last name";
            // 
            // ChoiceInfoLabel
            // 
            this.ChoiceInfoLabel.AutoSize = true;
            this.ChoiceInfoLabel.Location = new System.Drawing.Point(116, 29);
            this.ChoiceInfoLabel.Name = "ChoiceInfoLabel";
            this.ChoiceInfoLabel.Size = new System.Drawing.Size(47, 13);
            this.ChoiceInfoLabel.TabIndex = 3;
            this.ChoiceInfoLabel.Text = "must not";
            // 
            // ChoiceLabel
            // 
            this.ChoiceLabel.AutoSize = true;
            this.ChoiceLabel.Location = new System.Drawing.Point(12, 29);
            this.ChoiceLabel.Name = "ChoiceLabel";
            this.ChoiceLabel.Size = new System.Drawing.Size(40, 13);
            this.ChoiceLabel.TabIndex = 1;
            this.ChoiceLabel.Text = "Choice";
            // 
            // ChoiceCheckBox
            // 
            this.ChoiceCheckBox.AutoSize = true;
            this.ChoiceCheckBox.Location = new System.Drawing.Point(95, 29);
            this.ChoiceCheckBox.Name = "ChoiceCheckBox";
            this.ChoiceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ChoiceCheckBox.TabIndex = 2;
            this.ChoiceCheckBox.UseVisualStyleBackColor = true;
            this.ChoiceCheckBox.CheckedChanged += new System.EventHandler(this.OnChoiceCheckBoxCheckedChanged);
            // 
            // EventFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 186);
            this.Controls.Add(this.ChoiceInfoLabel);
            this.Controls.Add(this.ChoiceLabel);
            this.Controls.Add(this.ChoiceCheckBox);
            this.Controls.Add(this.UserLastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserFirstNameTextBox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.EventTypeLabel);
            this.Controls.Add(this.EventTypeComboBox);
            this.Controls.Add(this.FilterDescriptionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 225);
            this.Name = "EventFilterForm";
            this.Text = "Event Filter";
            this.Controls.SetChildIndex(this.FilterDescriptionLabel, 0);
            this.Controls.SetChildIndex(this.EventTypeComboBox, 0);
            this.Controls.SetChildIndex(this.EventTypeLabel, 0);
            this.Controls.SetChildIndex(this.ValueLabel, 0);
            this.Controls.SetChildIndex(this.UserFirstNameTextBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.UserLastNameTextBox, 0);
            this.Controls.SetChildIndex(this.ChoiceCheckBox, 0);
            this.Controls.SetChildIndex(this.ChoiceLabel, 0);
            this.Controls.SetChildIndex(this.ChoiceInfoLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventTypeLabel;
        private System.Windows.Forms.ComboBox EventTypeComboBox;
        private System.Windows.Forms.Label FilterDescriptionLabel;
        private System.Windows.Forms.TextBox UserFirstNameTextBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox UserLastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ChoiceInfoLabel;
        private System.Windows.Forms.Label ChoiceLabel;
        private System.Windows.Forms.CheckBox ChoiceCheckBox;
    }
}