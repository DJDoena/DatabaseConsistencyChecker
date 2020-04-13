using System;
using System.Linq;
using System.Windows.Forms;

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
        protected MultiLogicFilterForm() : this(default)
        {
        }

        protected static bool ValidateData(Configuration.Item[] items)
        {
            if (items == null || items.Length == 0)
            {
                MessageBox.Show("Value is empty!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else if (items.Length < 2)
            {
                MessageBox.Show("There must be at least two filters!", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {
                return true;
            }
        }

        protected static void FillFilterListView(Configuration.Item[] items, ListView filterListView)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    AddFilterListRow(item, filterListView);
                }
            }
        }

        private static void AddFilterListRow(Configuration.Item item, ListView filterListView)
        {
            var row = new ListViewItem();

            DrawFilterListItem(row, item);

            filterListView.Items.Add(row);
        }

        protected static void DrawFilterListItem(ListViewItem row, Configuration.Item item)
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

        protected Configuration.Item[] AddFilter(Configuration.Item[] items, ComboBox filterTypeComboBox, ListView filterListView)
        {
            var type = (Type)filterTypeComboBox.SelectedValue;

            var newItem = (Configuration.Item)Activator.CreateInstance(type);

            if (OpenFilterWindow(newItem))
            {
                var list = (items ?? Enumerable.Empty<Configuration.Item>()).ToList();

                list.Add(newItem);

                items = list.ToArray();

                AddFilterListRow(newItem, filterListView);

                HasChanged = true;
            }

            return items;
        }

        protected void EditFilter(Configuration.Item[] items, ListView filterListView)
        {
            var row = filterListView.SelectedItems[0];

            var original = (Configuration.Item)row.Tag;

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

        protected Configuration.Item[] RemoveFilter(Configuration.Item[] items, ListView filterListView)
        {
            var row = filterListView.SelectedItems[0];

            var obsolete = (Configuration.Item)row.Tag;

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