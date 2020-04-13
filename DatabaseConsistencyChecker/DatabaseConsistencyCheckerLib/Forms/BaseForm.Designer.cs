namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    partial class BaseForm<T>
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.DiscardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveCloseButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(790, 694);
            this.SaveButton.Name = "SaveCloseButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save && Close";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // CancelDiscardButton
            // 
            this.DiscardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscardButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DiscardButton.Location = new System.Drawing.Point(896, 694);
            this.DiscardButton.Name = "CancelDiscardButton";
            this.DiscardButton.Size = new System.Drawing.Size(100, 23);
            this.DiscardButton.TabIndex = 1;
            this.DiscardButton.Text = "Cancel";
            this.DiscardButton.UseVisualStyleBackColor = true;
            this.DiscardButton.Click += new System.EventHandler(this.OnDiscardButtonClick);
            // 
            // BaseForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DiscardButton;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.DiscardButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DiscardButton;
    }
}