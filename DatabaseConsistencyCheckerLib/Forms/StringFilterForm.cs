using System.Windows.Forms;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class StringFilterForm : BaseForm<Configuration.StringItem>
    {
        public StringFilterForm(Configuration.StringItem value) : base(value)
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