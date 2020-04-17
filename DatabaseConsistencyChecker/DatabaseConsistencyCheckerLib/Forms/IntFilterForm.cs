using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class IntFilterForm : BaseForm<Config.IntValueItem>
    {
        public IntFilterForm(Config.IntValueItem value) : base(value)
        {
            InitializeComponent();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ValueUpDown.Value = EditValue.Value;

            ArrangeControls();

            HasChanged = false;
        }

        private void OnValueUpDownValueChanged(object sender, System.EventArgs e)
        {
            EditValue.Value = (int)ValueUpDown.Value;

            HasChanged = true;
        }
    }
}