using System;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class EventFilterForm : BaseForm<Configuration.HasEventItem>
    {
        public EventFilterForm(Configuration.HasEventItem value) : base(value)
        {
            InitializeComponent();

            ArrangeControls();

            EventTypeComboBox.Items.Add(Configuration.HasEventItemEventType.Watched.ToString());
            EventTypeComboBox.Items.Add(Configuration.HasEventItemEventType.Borrowed.ToString());
            EventTypeComboBox.Items.Add(Configuration.HasEventItemEventType.Returned.ToString());

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            EventTypeComboBox.SelectedItem = EditValue.EventType.ToString();
            UserFirstNameTextBox.Text = EditValue.UserFirstName;
            UserLastNameTextBox.Text = EditValue.UserLastName;

            HasChanged = false;
        }

        private void OnEventTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            EditValue.EventType = (Configuration.HasEventItemEventType)Enum.Parse(typeof(Configuration.HasEventItemEventType), EventTypeComboBox.Text);

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