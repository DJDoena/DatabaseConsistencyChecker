using System;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Forms
{
    public sealed class FilterTypeComboBoxItem
    {
        public Type ValueMember { get; }

        public string DisplayMember { get; }

        public FilterTypeComboBoxItem(Type type)
        {
            ValueMember = type;

            DisplayMember = ConfigurationItemHelper.GetDisplayValue(type);
        }
    }
}