using System;
using System.Linq;
using System.Windows.Forms;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class ConfigurationForm : BaseForm<Config.CheckConfiguration>
    {
        public ConfigurationForm(Config.CheckConfiguration config) : base(config)
        {
            InitializeComponent();

            ArrangeControls();

            FillRuleListView();
            SwitchRuleControls();

            HasChanged = false;
        }

        protected override bool ValidateData()
        {
            if (RuleListView.Items.Count == 0)
            {
                MessageBox.Show("Rules are empty!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {
                return true;
            }
        }

        private void FillRuleListView()
        {
            if (EditValue.Rule != null)
            {
                foreach (var rule in EditValue.Rule)
                {
                    AddRuleListRow(rule);
                }
            }
        }

        private void AddRuleListRow(Config.RuleItem rule)
        {
            var row = new ListViewItem();

            DrawRuleListItem(row, rule);

            RuleListView.Items.Add(row);
        }

        private void DrawRuleListItem(ListViewItem row, Config.RuleItem item)
        {
            row.Tag = item;

            row.SubItems[0].Text = item.Name;
        }

        private void OnAddRuleButtonClick(object sender, EventArgs e)
        {
            var newItem = new Config.RuleItem();

            using (var form = new RuleForm(newItem))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var list = (EditValue.Rule ?? Enumerable.Empty<Config.RuleItem>()).ToList();

                    list.Add(newItem);

                    EditValue.Rule = list.ToArray();

                    AddRuleListRow(newItem);

                    HasChanged = true;
                }
            }
        }

        private void OnEditRuleButtonClick(object sender, EventArgs e)
        {
            var row = RuleListView.SelectedItems[0];

            var original = (Config.RuleItem)row.Tag;

            var copy = original.Clone();

            using (var form = new RuleForm(copy))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DrawRuleListItem(row, copy);

                    for (var itemIndex = 0; itemIndex < EditValue.Rule.Length; itemIndex++)
                    {
                        if (ReferenceEquals(original, EditValue.Rule[itemIndex]))
                        {
                            EditValue.Rule[itemIndex] = copy;

                            break;
                        }
                    }

                    HasChanged = true;
                }
            }
        }

        private void OnRemoveRuleButtonClick(object sender, EventArgs e)
        {
            var row = RuleListView.SelectedItems[0];

            var obsolete = (Config.RuleItem)row.Tag;

            RuleListView.Items.Remove(row);

            var list = EditValue.Rule.ToList();

            for (var itemIndex = list.Count - 1; itemIndex >= 0; itemIndex--)
            {
                if (ReferenceEquals(obsolete, list[itemIndex]))
                {
                    list.RemoveAt(itemIndex);

                    break;
                }
            }

            EditValue.Rule = list.ToArray();

            HasChanged = true;
        }

        private void OnRuleListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchRuleControls();
        }

        private void SwitchRuleControls()
        {
            EditRuleButton.Enabled = RuleListView.SelectedIndices.Count > 0;
            RemoveRuleButton.Enabled = RuleListView.SelectedIndices.Count > 0;
        }
    }
}