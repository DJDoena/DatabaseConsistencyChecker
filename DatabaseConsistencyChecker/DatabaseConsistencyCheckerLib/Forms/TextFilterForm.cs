using System;
using System.Windows.Forms;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_2;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class TextFilterForm : BaseForm<Config.StringItem>
    {
        public TextFilterForm(Config.StringItem value) : base(value)
        {
            InitializeComponent();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ChoiceCheckBox.Checked = EditValue.Choice;
            ValueTextBox.Text = EditValue.Value;

            ArrangeControls();

            SetLabels();

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

        private void OnChoiceCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            EditValue.Choice = ChoiceCheckBox.Checked;

            HasChanged = true;

            SetLabels();
        }

        private void SetLabels()
        {
            ChoiceInfoLabel.Text = EditValue.Choice
              ? "must be"
              : "must not be";
        }

        private void OnValueTextBoxTextChanged(object sender, EventArgs e)
        {
            EditValue.Value = ValueTextBox.Text;

            HasChanged = true;
        }
    }
}