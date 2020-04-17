namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class ChoiceStringFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceStringFilterForm));
            this.ValueLabel = new System.Windows.Forms.Label();
            this.FilterDescriptionLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ChoiceLabel = new System.Windows.Forms.Label();
            this.ChoiceCheckBox = new System.Windows.Forms.CheckBox();
            this.ChoiceInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(12, 52);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(34, 13);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Value";
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
            // ValueTextBox
            // 
            this.ValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTextBox.Location = new System.Drawing.Point(58, 49);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(514, 20);
            this.ValueTextBox.TabIndex = 5;
            this.ValueTextBox.TextChanged += new System.EventHandler(this.OnValueTextBoxTextChanged);
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
            this.ChoiceCheckBox.Location = new System.Drawing.Point(58, 29);
            this.ChoiceCheckBox.Name = "ChoiceCheckBox";
            this.ChoiceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ChoiceCheckBox.TabIndex = 2;
            this.ChoiceCheckBox.UseVisualStyleBackColor = true;
            this.ChoiceCheckBox.CheckedChanged += new System.EventHandler(this.OnChoiceCheckBoxCheckedChanged);
            // 
            // ChoiceInfoLabel
            // 
            this.ChoiceInfoLabel.AutoSize = true;
            this.ChoiceInfoLabel.Location = new System.Drawing.Point(79, 29);
            this.ChoiceInfoLabel.Name = "ChoiceInfoLabel";
            this.ChoiceInfoLabel.Size = new System.Drawing.Size(47, 13);
            this.ChoiceInfoLabel.TabIndex = 3;
            this.ChoiceInfoLabel.Text = "must not";
            // 
            // ChoiceStringFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.ChoiceInfoLabel);
            this.Controls.Add(this.ChoiceLabel);
            this.Controls.Add(this.ChoiceCheckBox);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.FilterDescriptionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "ChoiceStringFilterForm";
            this.Text = "Text Filter";
            this.Controls.SetChildIndex(this.FilterDescriptionLabel, 0);
            this.Controls.SetChildIndex(this.ValueLabel, 0);
            this.Controls.SetChildIndex(this.ValueTextBox, 0);
            this.Controls.SetChildIndex(this.ChoiceCheckBox, 0);
            this.Controls.SetChildIndex(this.ChoiceLabel, 0);
            this.Controls.SetChildIndex(this.ChoiceInfoLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label FilterDescriptionLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label ChoiceLabel;
        private System.Windows.Forms.CheckBox ChoiceCheckBox;
        private System.Windows.Forms.Label ChoiceInfoLabel;
    }
}