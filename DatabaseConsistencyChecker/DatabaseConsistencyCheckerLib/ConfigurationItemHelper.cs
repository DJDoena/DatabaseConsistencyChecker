using System;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker
{
    public static class ConfigurationItemHelper
    {
        public static string GetDisplayValue(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            var typeName = type.Name;

            var rm = ConfigurationItemResources.ResourceManager;

            var result = rm.GetString(typeName) ?? typeName;

            return result;
        }

        public static string GetDisplayValue(Configuration.Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            var result = GetDisplayValue(item.GetType());

            return result;
        }
    }
}