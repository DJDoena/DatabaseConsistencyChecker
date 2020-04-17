using System;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class ChoiceFilterForm : BaseForm<Config.ChoiceItem>
    {
        public ChoiceFilterForm(Config.ChoiceItem value) : base(value)
        {
            InitializeComponent();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ValueCheckBox.Checked = EditValue.Choice;

            ArrangeControls();

            HasChanged = false;
        }

        private void OnValueCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            EditValue.Choice = ValueCheckBox.Checked;

            HasChanged = true;
        }
    }
}