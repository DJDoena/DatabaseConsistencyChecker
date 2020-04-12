using System;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class BooleanFilterForm : BaseForm<Configuration.BooleanItem>
    {
        public BooleanFilterForm(Configuration.BooleanItem value) : base(value)
        {
            InitializeComponent();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ValueCheckBox.Checked = EditValue.Value;

            ArrangeControls();

            HasChanged = false;
        }

        private void OnValueCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            EditValue.Value = ValueCheckBox.Checked;

            HasChanged = true;
        }
    }
}