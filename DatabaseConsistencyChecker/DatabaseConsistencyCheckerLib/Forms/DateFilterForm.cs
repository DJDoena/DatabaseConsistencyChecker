using System;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_2;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class DateFilterForm : BaseForm<Config.DateItem>
    {
        public DateFilterForm(Config.DateItem value) : base(value)
        {
            InitializeComponent();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ChoiceCheckBox.Checked = EditValue.Choice;
            ValueDateTimePicker.Value = EditValue.Value;
            IsTodayCheckBox.Checked = EditValue.IsToday;

            ArrangeControls();

            SetLabels();

            SetPicker();

            HasChanged = false;
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
               ? "must be larger than"
               : "must be smaller than";
        }

        private void OnValueDateTimePickerValueChanged(object sender, EventArgs e)
        {
            EditValue.Value = ValueDateTimePicker.Value.Date;

            HasChanged = true;
        }

        private void OnIsTodayCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            EditValue.IsToday = IsTodayCheckBox.Checked;

            HasChanged = true;

            SetPicker();
        }

        private void SetPicker()
        {
            if (IsTodayCheckBox.Checked)
            {
                ValueDateTimePicker.Value = DateTime.Today;

                ValueDateTimePicker.Enabled = false;
            }
            else
            {
                ValueDateTimePicker.Enabled = true;
            }
        }
    }
}