using System;

namespace Olbrasoft.Extensions
{
    public static class StringExtensions
    {
        public static string Truncate(this string value, int maxLength, bool atWord = false)
        {
            if (string.IsNullOrEmpty(value)) return value;

            if (atWord) return TruncateAtWord(value, maxLength);

            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        private static string TruncateAtWord(this string value, int length)
        {
            if (value.Length < length) return value;

            int iNextSpace = value.LastIndexOf(" ", length, StringComparison.Ordinal);
            return string.Format("{0}", value.Substring(0, (iNextSpace > 0) ? iNextSpace : length).Trim());
        }
    }
}