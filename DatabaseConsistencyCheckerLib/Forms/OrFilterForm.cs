using System;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class OrFilterForm : MultiLogicFilterForm<Configuration.OrItem>
    {
        public OrFilterForm(Configuration.OrItem value) : base(value)
        {
            InitializeComponent();

            ArrangeControls();

            FillFilterType(FilterTypeComboBox);
            FillFilterListView(EditValue.Or, FilterListView);
            SwitchFilterControls();

            HasChanged = false;
        }

        protected override bool ValidateData()
        {
            var result = ValidateData(EditValue.Or);

            return result;
        }

        private void OnAddFilterButtonClick(object sender, EventArgs e)
        {
            EditValue.Or = AddFilter(EditValue.Or, FilterTypeComboBox, FilterListView);

            SwitchFilterControls();
        }

        private void OnEditFilterButtonClick(object sender, EventArgs e)
        {
            EditFilter(EditValue.Or, FilterListView);

            SwitchFilterControls();
        }

        private void OnRemoveFilterButtonClick(object sender, EventArgs e)
        {
            EditValue.Or = RemoveFilter(EditValue.Or, FilterListView);

            SwitchFilterControls();
        }

        private void OnFilterListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchFilterControls();
        }

        private void SwitchFilterControls()
        {
            EditFilterButton.Enabled = FilterListView.SelectedIndices.Count > 0;
            RemoveFilterButton.Enabled = FilterListView.SelectedIndices.Count > 0;
        }
    }
}