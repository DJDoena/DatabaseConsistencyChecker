using System.Linq;
using System.Windows.Forms;

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
        protected BaseForm() : this(default)
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
            var baseType = typeof(Configuration.Item);

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

        protected bool OpenFilterWindow(Configuration.Item filter)
        {
            switch (filter)
            {
                case Configuration.BooleanItem booleanFilter:
                    {
                        using (var form = new BooleanFilterForm(booleanFilter))
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
                case Configuration.IntItem intFilter:
                    {
                        using (var form = new IntFilterForm(intFilter))
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
                case Configuration.StringItem stringFilter:
                    {
                        using (var form = new StringFilterForm(stringFilter))
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
                case Configuration.HasEventItem eventItem:
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
                case Configuration.ExceptItem exceptItem:
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
                case Configuration.AndItem andItem:
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
                case Configuration.OrItem orItem:
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
                case Configuration.NoParamItem _:
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

        private void OnSaveButtonClick(object sender, System.EventArgs e)
        {
            if (ValidateData())
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void OnDiscardButtonClick(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}