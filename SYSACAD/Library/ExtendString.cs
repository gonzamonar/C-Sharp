using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class ExtendString
    {
        public static string ToTitle(this string str)
        {
            StringBuilder sb = new StringBuilder();
            int len = str.Length;

            if (str is not null && len > 2)
            {
                sb.Append(Char.ToUpper(str[0]));
                for (int i = 1; i < len; i++)
                {
                    if (str[i - 1] == ' ')
                    {
                        sb.Append(Char.ToUpper(str[i]));
                    }
                    else
                    {
                        sb.Append(Char.ToLower(str[i]));
                    }
                }
            }
            return sb.ToString().Trim();
        }



        //public static string ToTitle(this string str)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    string[] words = str.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        //    foreach (string word in words)
        //    {
        //        word[0] = Char.ToUpper(word[0]);
        //        sb.Append(word);
        //        sb.Append(' ');
        //    }
            
        //    return sb.ToString().Trim();
        //}
    }
}