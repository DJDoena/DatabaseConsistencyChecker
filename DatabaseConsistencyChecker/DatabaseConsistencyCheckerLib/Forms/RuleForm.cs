using System;
using System.Linq;
using System.Windows.Forms;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class RuleForm : BaseForm<Config.RuleItem>
    {
        public RuleForm(Config.RuleItem rule) : base(rule)
        {
            InitializeComponent();

            ArrangeControls();

            RuleNameTextBox.Text = EditValue.Name;

            FillFilterType(FilterTypeComboBox);
            FillFilterListView();
            SwitchFilterControls();

            FillCheckListView();
            SwitchCheckControls();

            HasChanged = false;
        }

        protected override bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(RuleNameTextBox.Text))
            {
                MessageBox.Show("Name is empty!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else if (CheckListView.Items.Count == 0)
            {
                MessageBox.Show("Checks are empty!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {
                return true;
            }
        }

        #region Filter

        private void FillFilterListView()
        {
            FilterListView.Items.Clear();

            if (EditValue.Filter != null)
            {
                var row = new ListViewItem();

                DrawFilterListItem(row, EditValue.Filter);

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
                EditValue.Filter = newItem;

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

                EditValue.Filter = copy;

                HasChanged = true;
            }

            SwitchFilterControls();
        }

        private void OnRemoveFilterButtonClick(object sender, EventArgs e)
        {
            var row = FilterListView.SelectedItems[0];

            FilterListView.Items.Remove(row);

            EditValue.Filter = null;

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

        #endregion

        #region Check

        private void FillCheckListView()
        {
            if (EditValue.Check != null)
            {
                foreach (var check in EditValue.Check)
                {
                    AddCheckListRow(check);
                }
            }
        }

        private void AddCheckListRow(Config.CheckItem check)
        {
            var row = new ListViewItem();

            DrawCheckListItem(row, check);

            CheckListView.Items.Add(row);
        }

        private void DrawCheckListItem(ListViewItem row, Config.CheckItem item)
        {
            row.Tag = item;

            row.SubItems[0].Text = item.Name;
        }

        private void OnAddCheckButtonClick(object sender, EventArgs e)
        {
            var newItem = new Config.CheckItem();

            using (var form = new CheckForm(newItem))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var list = (EditValue.Check ?? Enumerable.Empty<Config.CheckItem>()).ToList();

                    list.Add(newItem);

                    EditValue.Check = list.ToArray();

                    AddCheckListRow(newItem);

                    HasChanged = true;
                }
            }
        }

        private void OnEditCheckButtonClick(object sender, EventArgs e)
        {
            var row = CheckListView.SelectedItems[0];

            var original = (Config.CheckItem)row.Tag;

            var copy = original.Clone();

            using (var form = new CheckForm(copy))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DrawCheckListItem(row, copy);

                    for (var itemIndex = 0; itemIndex < EditValue.Check.Length; itemIndex++)
                    {
                        if (ReferenceEquals(original, EditValue.Check[itemIndex]))
                        {
                            EditValue.Check[itemIndex] = copy;

                            break;
                        }
                    }

                    HasChanged = true;
                }
            }
        }

        private void OnRemoveCheckButtonClick(object sender, EventArgs e)
        {
            var row = CheckListView.SelectedItems[0];

            var obsolete = (Config.CheckItem)row.Tag;

            CheckListView.Items.Remove(row);

            var list = EditValue.Check.ToList();

            for (var itemIndex = list.Count - 1; itemIndex >= 0; itemIndex--)
            {
                if (ReferenceEquals(obsolete, list[itemIndex]))
                {
                    list.RemoveAt(itemIndex);

                    break;
                }
            }

            EditValue.Check = list.ToArray();

            HasChanged = true;
        }

        private void OnCheckListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchCheckControls();
        }

        private void SwitchCheckControls()
        {
            EditCheckButton.Enabled = CheckListView.SelectedIndices.Count > 0;
            RemoveCheckButton.Enabled = CheckListView.SelectedIndices.Count > 0;
        }

        #endregion

        private void OnRuleNameTextBoxTextChanged(object sender, EventArgs e)
        {
            EditValue.Name = RuleNameTextBox.Text;

            HasChanged = true;
        }
    }
}