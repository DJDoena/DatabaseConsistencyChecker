using System;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class AndFilterForm : MultiLogicFilterForm<Config.AndItem>
    {
        public AndFilterForm(Config.AndItem value) : base(value)
        {
            InitializeComponent();

            ArrangeControls();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            FillFilterType(FilterTypeComboBox);
            FillFilterListView(EditValue.And, FilterListView);
            SwitchFilterControls();

            HasChanged = false;
        }

        protected override bool ValidateData()
        {
            var result = ValidateData(EditValue.And);

            return result;
        }

        private void OnAddFilterButtonClick(object sender, EventArgs e)
        {
            EditValue.And = AddFilter(EditValue.And, FilterTypeComboBox, FilterListView);

            SwitchFilterControls();
        }

        private void OnEditFilterButtonClick(object sender, EventArgs e)
        {
            EditFilter(EditValue.And, FilterListView);

            SwitchFilterControls();
        }

        private void OnRemoveFilterButtonClick(object sender, EventArgs e)
        {
            EditValue.And = RemoveFilter(EditValue.And, FilterListView);

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