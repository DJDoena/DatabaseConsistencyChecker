using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class NumericFilterForm : BaseForm<Config.IntItem>
    {
        public NumericFilterForm(Config.IntItem value) : base(value)
        {
            InitializeComponent();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ChoiceCheckBox.Checked = EditValue.Choice;
            ValueUpDown.Value = EditValue.Value;

            ArrangeControls();

            HasChanged = false;
        }

        private void OnChoiceCheckBoxCheckedChanged(object sender, System.EventArgs e)
        {
            EditValue.Choice = ChoiceCheckBox.Checked;

            HasChanged = true;

            ChoiceInfoLabel.Text = EditValue.Choice
                ? "must be"
                : "must not be";
        }

        private void OnValueUpDownValueChanged(object sender, System.EventArgs e)
        {
            EditValue.Value = (int)ValueUpDown.Value;

            HasChanged = true;
        }
    }
}