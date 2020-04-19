using System;
using System.Windows.Forms;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_2;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class ExceptFilterForm : BaseForm<Config.ExceptItem>
    {
        public ExceptFilterForm(Config.ExceptItem value) : base(value)
        {
            InitializeComponent();

            ArrangeControls();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            FillFilterType(FilterTypeComboBox);
            FillFilterListView();
            SwitchFilterControls();

            HasChanged = false;
        }

        protected override bool ValidateData()
        {
            if (EditValue.Except == null)
            {
                MessageBox.Show("Value is empty!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {
                return true;
            }
        }

        private void FillFilterListView()
        {
            if (EditValue.Except != null)
            {
                var row = new ListViewItem();

                DrawFilterListItem(row, EditValue.Except);

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
                EditValue.Except = newItem;

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

                EditValue.Except = copy;

                HasChanged = true;
            }

            SwitchFilterControls();
        }

        private void OnRemoveFilterButtonClick(object sender, EventArgs e)
        {
            var row = FilterListView.SelectedItems[0];

            FilterListView.Items.Remove(row);

            EditValue.Except = null;

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
    }
}