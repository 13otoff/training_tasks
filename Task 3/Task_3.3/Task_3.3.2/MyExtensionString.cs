using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_3._3._2
{
    public static class MyExtensionString
    {
        public static Language GetLanguage(this string text)
        {
            List<Language> l = new();
            if (Regex.IsMatch(text, @"[А-Яа-яЁё]")) l.Add(Language.Russian);
            if (Regex.IsMatch(text, @"[A-Za-z]")) l.Add(Language.English);
            if (Regex.IsMatch(text, @"[0-9]")) l.Add(Language.Number);

            if (l.Count > 1 || Regex.IsMatch(text, @"[\W^]")) return Language.Mixed;

            return l.FirstOrDefault();
        }
    }
}
