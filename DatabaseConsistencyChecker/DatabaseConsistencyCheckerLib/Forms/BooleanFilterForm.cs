﻿using System;
using Config = DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Configuration_v1_1;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public partial class BooleanFilterForm : BaseForm<Config.BooleanValueItem>
    {
        public BooleanFilterForm(Config.BooleanValueItem value) : base(value)
        {
            InitializeComponent();

            FilterDescriptionLabel.Text = ConfigurationItemHelper.GetDisplayValue(EditValue);

            ValueCheckBox.Checked = EditValue.Value;

            ArrangeControls();

            HasChanged = false;
        }

        private void OnValueCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            EditValue.Value = ValueCheckBox.Checked;

            HasChanged = true;
        }
    }
}