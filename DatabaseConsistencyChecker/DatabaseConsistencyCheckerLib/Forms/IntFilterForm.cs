namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class IntFilterForm : BaseForm<Configuration.IntItem>
    {
        public IntFilterForm(Configuration.IntItem value) : base(value)
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