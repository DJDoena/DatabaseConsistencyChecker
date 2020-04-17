namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class ChoiceFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceFilterForm));
            this.ValueCheckBox = new System.Windows.Forms.CheckBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.FilterDescriptionLabel = new System.Windows.Forms.Label();
            this.ChoiceInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueCheckBox
            // 
            this.ValueCheckBox.AutoSize = true;
            this.ValueCheckBox.Location = new System.Drawing.Point(52, 28);
            this.ValueCheckBox.Name = "ValueCheckBox";
            this.ValueCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ValueCheckBox.TabIndex = 2;
            this.ValueCheckBox.UseVisualStyleBackColor = true;
            this.ValueCheckBox.CheckedChanged += new System.EventHandler(this.OnValueCheckBoxCheckedChanged);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(12, 29);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(34, 13);
            this.ValueLabel.TabIndex = 1;
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
            // ChoiceInfoLabel
            // 
            this.ChoiceInfoLabel.AutoSize = true;
            this.ChoiceInfoLabel.Location = new System.Drawing.Point(73, 29);
            this.ChoiceInfoLabel.Name = "ChoiceInfoLabel";
            this.ChoiceInfoLabel.Size = new System.Drawing.Size(47, 13);
            this.ChoiceInfoLabel.TabIndex = 3;
            this.ChoiceInfoLabel.Text = "must not";
            // 
            // ChoiceFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 161);
            this.Controls.Add(this.ChoiceInfoLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.FilterDescriptionLabel);
            this.Controls.Add(this.ValueCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 200);
            this.Name = "ChoiceFilterForm";
            this.Text = "True/False Filter";
            this.Controls.SetChildIndex(this.ValueCheckBox, 0);
            this.Controls.SetChildIndex(this.FilterDescriptionLabel, 0);
            this.Controls.SetChildIndex(this.ValueLabel, 0);
            this.Controls.SetChildIndex(this.ChoiceInfoLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ValueCheckBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label FilterDescriptionLabel;
        private System.Windows.Forms.Label ChoiceInfoLabel;
    }
}