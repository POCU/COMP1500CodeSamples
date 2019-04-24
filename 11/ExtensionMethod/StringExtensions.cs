using System.Text;

namespace ExtensionMethod
{
    public static class StringExtensions
    {
        public static string Reverse(this string s)
        {
            StringBuilder sb = new StringBuilder(s.Length);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }

        public static string Reverse(this string s, int start, int end)
        {
            if (start < 0 || end > s.Length || start > end - 1)
            {
                return s;
            }

            StringBuilder sb = new StringBuilder(s.Length);

            for (int i = 0; i < start; i++)
            {
                sb.Append(s[i]);
            }

            for (int i = end - 1; i >= start; i--)
            {
                sb.Append(s[i]);
            }

            for (int i = end; i < s.Length; i++)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
