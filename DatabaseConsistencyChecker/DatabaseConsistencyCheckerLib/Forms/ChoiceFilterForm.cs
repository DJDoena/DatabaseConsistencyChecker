using System;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_2;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class ChoiceFilterForm : BaseForm<Config.ValueItem>
    {
        public ChoiceFilterForm(Config.ValueItem value) : base(value)
        {
            InitializeComponent();

            Icon = Properties.Resources.DJDSOFT;

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ValueCheckBox.Checked = EditValue.Choice;

            ArrangeControls();

            SetLabels();

            HasChanged = false;            
        }

        private void OnValueCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            EditValue.Choice = ValueCheckBox.Checked;

            HasChanged = true;

            SetLabels();
        }

        private void SetLabels()
        {
            ChoiceInfoLabel.Text = EditValue.Choice
              ? "must be"
              : "must not be";
        }
    }
}