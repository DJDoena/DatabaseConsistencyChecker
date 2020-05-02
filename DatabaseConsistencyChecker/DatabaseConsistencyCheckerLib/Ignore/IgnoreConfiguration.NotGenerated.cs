using System.Text;

namespace DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Ignore
{
    partial class Profile
    {
        //xsd.exe IgnoreConfiguration.xsd /c /l:cs /f /n:DoenaSoft.DVDProfiler.DatabaseConsistencyChecker.Ignore

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(Title);

            if (!string.IsNullOrWhiteSpace(Edition))
            {
                sb.Append(": ");
                sb.Append(Edition);
            }

            sb.Append(" (");
            sb.Append(UPC);

            if (ID_VariantNum > 0)
            {
                sb.Append(" #");
                sb.Append(ID_VariantNum);
            }

            sb.Append(")");

            return sb.ToString();
        }
    }
}