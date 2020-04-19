using System.Linq;
using System.Windows.Forms;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_2;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public class MultiLogicFilterForm<T> : BaseForm<T>
    {
        public MultiLogicFilterForm(T value) : base(value)
        {
        }

        /// <remarks>
        /// Only for designer!
        /// </remarks>
        public MultiLogicFilterForm() : this(default)
        {
        }

        protected static bool ValidateData(Config.Item[] items)
        {
            if (items == null || items.Length < 2)
            {
                MessageBox.Show("There must be at least two filters!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {
                return true;
            }
        }

        protected static void FillFilterListView(Config.Item[] items, ListView filterListView)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    AddFilterListRow(item, filterListView);
                }
            }
        }

        private static void AddFilterListRow(Config.Item item, ListView filterListView)
        {
            var row = new ListViewItem();

            DrawFilterListItem(row, item);

            filterListView.Items.Add(row);
        }

        protected static void DrawFilterListItem(ListViewItem row, Config.Item item)
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

        protected Config.Item[] AddFilter(Config.Item[] items, ComboBox filterTypeComboBox, ListView filterListView)
        {
            var newItem = CreateInstance(filterTypeComboBox);

            if (OpenFilterWindow(newItem))
            {
                var list = (items ?? Enumerable.Empty<Config.Item>()).ToList();

                list.Add(newItem);

                items = list.ToArray();

                AddFilterListRow(newItem, filterListView);

                HasChanged = true;
            }

            return items;
        }

        protected void EditFilter(Config.Item[] items, ListView filterListView)
        {
            var row = filterListView.SelectedItems[0];

            var original = (Config.Item)row.Tag;

            var copy = original.Clone();

            if (OpenFilterWindow(copy))
            {
                DrawFilterListItem(row, copy);

                for (var itemIndex = 0; itemIndex < items.Length; itemIndex++)
                {
                    if (ReferenceEquals(original, items[itemIndex]))
                    {
                        items[itemIndex] = copy;

                        break;
                    }
                }

                HasChanged = true;
            }
        }

        protected Config.Item[] RemoveFilter(Config.Item[] items, ListView filterListView)
        {
            var row = filterListView.SelectedItems[0];

            var obsolete = (Config.Item)row.Tag;

            filterListView.Items.Remove(row);

            var list = items.ToList();

            for (var itemIndex = list.Count - 1; itemIndex >= 0; itemIndex--)
            {
                if (ReferenceEquals(obsolete, list[itemIndex]))
                {
                    list.RemoveAt(itemIndex);

                    break;
                }
            }

            items = list.ToArray();

            HasChanged = true;

            return items;
        }
    }
}