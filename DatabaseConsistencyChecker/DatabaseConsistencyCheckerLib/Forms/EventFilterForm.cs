using System;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class EventFilterForm : BaseForm<Config.HasEventItem>
    {
        public EventFilterForm(Config.HasEventItem value) : base(value)
        {
            InitializeComponent();

            ArrangeControls();

            EventTypeComboBox.Items.Add(Config.HasEventItemEventType.Watched.ToString());
            EventTypeComboBox.Items.Add(Config.HasEventItemEventType.Borrowed.ToString());
            EventTypeComboBox.Items.Add(Config.HasEventItemEventType.Returned.ToString());

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            EventTypeComboBox.SelectedItem = EditValue.EventType.ToString();
            UserFirstNameTextBox.Text = EditValue.UserFirstName;
            UserLastNameTextBox.Text = EditValue.UserLastName;

            HasChanged = false;
        }

        private void OnEventTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            EditValue.EventType = (Config.HasEventItemEventType)Enum.Parse(typeof(Config.HasEventItemEventType), EventTypeComboBox.Text);

            HasChanged = true;
        }

        private void OnUserFirstNameTextBoxTextChanged(object sender, EventArgs e)
        {
            EditValue.UserFirstName = UserFirstNameTextBox.Text;

            HasChanged = true;
        }

        private void OnUserLastNameTextBoxTextChanged(object sender, EventArgs e)
        {
            EditValue.UserLastName = UserLastNameTextBox.Text;

            HasChanged = true;
        }
    }
}