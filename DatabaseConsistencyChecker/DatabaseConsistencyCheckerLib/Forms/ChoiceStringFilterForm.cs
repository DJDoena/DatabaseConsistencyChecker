using System.Windows.Forms;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class ChoiceStringFilterForm : BaseForm<Config.ChoiceStringItem>
    {
        public ChoiceStringFilterForm(Config.ChoiceStringItem value) : base(value)
        {
            InitializeComponent();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ChoiceCheckBox.Checked = EditValue.Choice;
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

        private void OnChoiceCheckBoxCheckedChanged(object sender, System.EventArgs e)
        {
            EditValue.Choice = ChoiceCheckBox.Checked;

            HasChanged = true;

            ChoiceInfoLabel.Text = EditValue.Choice
                ? "must be"
                : "must not be";
        }

        private void OnValueTextBoxTextChanged(object sender, System.EventArgs e)
        {
            EditValue.Value = ValueTextBox.Text;

            HasChanged = true;
        }
    }
}