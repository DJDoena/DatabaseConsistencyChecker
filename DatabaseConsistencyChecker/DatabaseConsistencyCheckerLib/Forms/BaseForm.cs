using System;
using System.Linq;
using System.Windows.Forms;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v2_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class BaseForm<T> : Form
    {
        protected bool HasChanged { get; set; }

        protected T EditValue { get; private set; }

        public BaseForm(T value)
        {
            EditValue = value;

            InitializeComponent();
        }

        /// <remarks>
        /// Only for designer!
        /// </remarks>
        public BaseForm() : this(default)
        {
        }

        protected void ArrangeControls()
        {
            SaveButton.Left = Width - 234;
            SaveButton.Top = Height - 74;
            SaveButton.TabIndex = 100;

            DiscardButton.Left = Width - 128;
            DiscardButton.Top = Height - 74;
            DiscardButton.TabIndex = 101;
        }

        protected virtual bool ValidateData() => true;

        protected void FillFilterType(ComboBox comboBox)
        {
            var baseType = typeof(Config.Item);

            var assembly = baseType.Assembly;

            var allTypes = assembly.GetExportedTypes();

            var itemTypes = allTypes.Where(t => t.IsSubclassOf(baseType) && !t.IsAbstract);

            var comboBoxItems = itemTypes.Select(t => new FilterTypeComboBoxItem(t)).ToList();

            comboBoxItems.Sort((left, right) => left.DisplayMember.CompareTo(right.DisplayMember));

            comboBox.DataSource = comboBoxItems;
            comboBox.ValueMember = nameof(FilterTypeComboBoxItem.ValueMember);
            comboBox.DisplayMember = nameof(FilterTypeComboBoxItem.DisplayMember);

            comboBox.SelectedIndex = 0;
        }

        protected bool OpenFilterWindow(Config.Item filter)
        {
            switch (filter)
            {
                case Config.IntItem intItem:
                    {
                        using (var form = new NumericFilterForm(intItem))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                case Config.StringItem stringItem:
                    {
                        using (var form = new TextFilterForm(stringItem))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                case Config.HasEventItem eventItem:
                    {
                        using (var form = new EventFilterForm(eventItem))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                case Config.DateItem dateItem:
                    {
                        using (var form = new DateFilterForm(dateItem))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                case Config.ValueItem choiceItem:
                    {
                        using (var form = new ChoiceFilterForm(choiceItem))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                case Config.ExceptItem exceptItem:
                    {
                        using (var form = new ExceptFilterForm(exceptItem))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                case Config.AndItem andItem:
                    {
                        using (var form = new AndFilterForm(andItem))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                case Config.OrItem orItem:
                    {
                        using (var form = new OrFilterForm(orItem))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                case Config.NoParameterItem _:
                    {
                        return true;
                    }
                default:
                    {
                        MessageBox.Show($"Unknown filter type '{filter.GetType().Name}'.", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (HasChanged && DialogResult != DialogResult.OK)
            {
                var confirmation = MessageBox.Show("You have unsaved changes. Really close without saving?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    //close & discard
                }
            }
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void OnDiscardButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        protected static Config.Item CreateInstance(ComboBox filterTypeComboBox)
        {
            var type = (Type)filterTypeComboBox.SelectedValue;

            var newItem = (Config.Item)Activator.CreateInstance(type);

            if (newItem is Config.ValueItem choiceItem)
            {
                choiceItem.Choice = true;
            }

            if (newItem is Config.DateItem dateItem)
            {
                dateItem.Value = DateTime.Today;
                dateItem.IsToday = true;
            }

            return newItem;
        }
    }
}