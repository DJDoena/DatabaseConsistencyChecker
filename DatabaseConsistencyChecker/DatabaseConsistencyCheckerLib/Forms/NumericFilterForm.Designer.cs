namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class NumericFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumericFilterForm));
            this.ValueLabel = new System.Windows.Forms.Label();
            this.FilterDescriptionLabel = new System.Windows.Forms.Label();
            this.ValueUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChoiceInfoLabel = new System.Windows.Forms.Label();
            this.ChoiceLabel = new System.Windows.Forms.Label();
            this.ChoiceCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ValueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(12, 51);
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
            // ValueUpDown
            // 
            this.ValueUpDown.Location = new System.Drawing.Point(58, 49);
            this.ValueUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ValueUpDown.Name = "ValueUpDown";
            this.ValueUpDown.Size = new System.Drawing.Size(120, 20);
            this.ValueUpDown.TabIndex = 5;
            this.ValueUpDown.ValueChanged += new System.EventHandler(this.OnValueUpDownValueChanged);
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
            // IntFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 161);
            this.Controls.Add(this.ChoiceInfoLabel);
            this.Controls.Add(this.ChoiceLabel);
            this.Controls.Add(this.ChoiceCheckBox);
            this.Controls.Add(this.ValueUpDown);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.FilterDescriptionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 200);
            this.Name = "IntFilterForm";
            this.Text = "Numeric Filter";
            this.Controls.SetChildIndex(this.FilterDescriptionLabel, 0);
            this.Controls.SetChildIndex(this.ValueLabel, 0);
            this.Controls.SetChildIndex(this.ValueUpDown, 0);
            this.Controls.SetChildIndex(this.ChoiceCheckBox, 0);
            this.Controls.SetChildIndex(this.ChoiceLabel, 0);
            this.Controls.SetChildIndex(this.ChoiceInfoLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValueUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label FilterDescriptionLabel;
        private System.Windows.Forms.NumericUpDown ValueUpDown;
        private System.Windows.Forms.Label ChoiceInfoLabel;
        private System.Windows.Forms.Label ChoiceLabel;
        private System.Windows.Forms.CheckBox ChoiceCheckBox;
    }
}