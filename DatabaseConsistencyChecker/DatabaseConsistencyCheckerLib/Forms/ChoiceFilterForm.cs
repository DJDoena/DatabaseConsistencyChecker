using System;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class ChoiceFilterForm : BaseForm<Config.ValueItem>
    {
        public ChoiceFilterForm(Config.ValueItem value) : base(value)
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

            ChoiceInfoLabel.Text = EditValue.Choice
              ? "must be"
              : "must not be";
        }
    }
}