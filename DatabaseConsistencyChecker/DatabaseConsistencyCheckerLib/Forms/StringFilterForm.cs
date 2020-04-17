﻿using System.Windows.Forms;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class StringFilterForm : BaseForm<Config.StringValueItem>
    {
        public StringFilterForm(Config.StringValueItem value) : base(value)
        {
            InitializeComponent();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ValueTextBox.Text = EditValue.Value;

            ArrangeControls();

            HasChanged = false;
        }

        protected override bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(EditValue.Value))
            {
                MessageBox.Show("Value is empty!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {
                return true;
            }
        }

        private void OnValueTextBoxTextChanged(object sender, System.EventArgs e)
        {
            EditValue.Value = ValueTextBox.Text;

            HasChanged = true;
        }
    }
}