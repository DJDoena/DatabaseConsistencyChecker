using System;
using System.Windows.Forms;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_2;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class CheckForm : BaseForm<Config.CheckItem>
    {
        public CheckForm(Config.CheckItem value) : base(value)
        {
            InitializeComponent();

            ArrangeControls();

            CheckNameTextBox.Text = EditValue.Name;

            FillFilterType(FilterTypeComboBox);
            FillFilterListView();
            SwitchFilterControls();

            HasChanged = false;
        }

        protected override bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(CheckNameTextBox.Text))
            {
                MessageBox.Show("Name is empty!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else if (EditValue.Item == null)
            {
                MessageBox.Show("Filter is empty!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {
                return true;
            }
        }

        private void FillFilterListView()
        {
            if (EditValue.Item != null)
            {
                var row = new ListViewItem();

                DrawFilterListItem(row, EditValue.Item);

                FilterListView.Items.Add(row);
            }
        }

        private static void DrawFilterListItem(ListViewItem row, Config.Item item)
        {
            row.Tag = item;

            row.SubItems[0].Text = ConfigurationItemHelper.GetDisplayValue(item);

            if (row.SubItems.Count == 1)
            {
                row.SubItems.Add(item.ToString());
            }
            else
            {
                row.SubItems[1].Text = item.ToString();
            }
        }

        private void OnAddFilterButtonClick(object sender, EventArgs e)
        {
            var newItem = CreateInstance(FilterTypeComboBox);

            if (OpenFilterWindow(newItem))
            {
                EditValue.Item = newItem;

                FillFilterListView();

                HasChanged = true;
            }

            SwitchFilterControls();
        }

        private void OnEditFilterButtonClick(object sender, EventArgs e)
        {
            var row = FilterListView.SelectedItems[0];

            var original = (Config.Item)row.Tag;

            var copy = original.Clone();

            if (OpenFilterWindow(copy))
            {
                DrawFilterListItem(row, copy);

                EditValue.Item = copy;

                HasChanged = true;
            }

            SwitchFilterControls();
        }

        private void OnRemoveFilterButtonClick(object sender, EventArgs e)
        {
            var row = FilterListView.SelectedItems[0];

            FilterListView.Items.Remove(row);

            EditValue.Item = null;

            HasChanged = true;

            SwitchFilterControls();
        }

        private void OnFilterListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchFilterControls();
        }

        private void SwitchFilterControls()
        {
            FilterTypeComboBox.Enabled = FilterListView.Items.Count == 0;
            AddFilterButton.Enabled = FilterListView.Items.Count == 0;
            EditFilterButton.Enabled = FilterListView.SelectedIndices.Count > 0;
            RemoveFilterButton.Enabled = FilterListView.SelectedIndices.Count > 0;
        }

        private void OnCheckNameTextBoxTextChanged(object sender, EventArgs e)
        {
            EditValue.Name = CheckNameTextBox.Text;

            HasChanged = true;
        }
    }
}