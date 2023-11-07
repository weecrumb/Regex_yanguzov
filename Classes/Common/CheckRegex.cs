using System.Text.RegularExpressions;

namespace Regex_yanguzov.Classes.Common
{
    public class CheckRegex
    {
        /// <param name="Pattern">Регулярное выражение</param> 
        /// <param name="Input">Строка ввода</param>
        /// <returns></returns>
        public static bool Match(string Pattern, string Input)
        {
            Match m = Regex.Match(Input, Pattern);
            return m.Success;
        }
    }
}
