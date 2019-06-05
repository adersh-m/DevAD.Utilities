using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAD.Utilities
{
    public static class StringExtentions
    {
        /// <summary>
        /// Converts file size in bytes to human readable format
        /// </summary>
        /// <param name="size">File size in bytes</param>
        /// <returns>File size in bytes/KB/MB/GB/TB/PB/EB</returns>
        public static string ToFileSize(this long size)
        {
            if(size == 0 || size == 1) {  return (size).ToString("F0") + " byte"; }
            if (size < 1024) { return (size).ToString("F0") + " bytes"; }
            if (size < Math.Pow(1024, 2)) { return (size / 1024).ToString("F0") + " KB"; }
            if (size < Math.Pow(1024, 3)) { return (size / Math.Pow(1024, 2)).ToString("F0") + " MB"; }
            if (size < Math.Pow(1024, 4)) { return (size / Math.Pow(1024, 3)).ToString("F0") + " GB"; }
            if (size < Math.Pow(1024, 5)) { return (size / Math.Pow(1024, 4)).ToString("F0") + " TB"; }
            if (size < Math.Pow(1024, 6)) { return (size / Math.Pow(1024, 5)).ToString("F0") + " PB"; }
            return (size / Math.Pow(1024, 6)).ToString("F0") + "EB";
        }

        /// <summary>
        /// Convert camel case strings to words by inserting spaces
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            var result = string.Empty;

            if(!string.IsNullOrWhiteSpace(source))
            {
                result = System.Text.RegularExpressions.Regex.Replace(source, "(?<=[a-z])([A-Z])", " $1", System.Text.RegularExpressions.RegexOptions.Compiled);
            }

            return result;
        }

        public static string RemoveLastCharacter(this string source)
        {
            return source.Substring(0, source.Length - 1);
        }


        public static string RemoveLast(this string source, int number)
        {
            return source.Substring(0, source.Length - number);
        }


        public static string RemoveFirstCharacter(this string source)
        {
            return source.Substring(1);
        }


        public static string RemoveFirst(this string source, int number)
        {
            return source.Substring(number);
        }
    }
}
