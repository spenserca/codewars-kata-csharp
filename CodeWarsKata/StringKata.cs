using System;
using System.Text;

namespace CodeWarsKata
{
    public class StringKata
    {
        public string ToCamelCase(string s)
        {
            var strings = s.Split(new[] { '-', '_' });

            return $"{strings[0]}{UpperCaseFirstChars(strings)}";
        }

        private string UpperCaseFirstChars(string[] strings)
        {
            var sb = new StringBuilder();
            for (int i = 1; i < strings.Length; i++)
            {
                var chars = strings[i].ToCharArray();
                chars[0] = Char.ToUpper(chars[0]);
                var s = string.Join("", chars);
                sb.Append(s);
            }

            return sb.ToString();
        }
    }
}
