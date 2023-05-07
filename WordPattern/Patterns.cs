using System.Collections.Generic;

namespace WordPattern
{
    public class Patterns
    {
        public bool FindPattern(string pattern, string patternToCheck)
        {
            Dictionary<char, string> dictonary = new Dictionary<char, string>();
            HashSet<string> set = new HashSet<string>();

            char[] patternArray = pattern.ToCharArray(); 

            string[] patternToCheckArray = patternToCheck.Split(' ');  


            if (pattern.Length != patternToCheckArray.Length) return false;

            for (int i = 0; i < patternArray.Length; i++)
            {
                if (dictonary.ContainsKey(patternArray[i]))
                {
                    if (patternToCheckArray[i] != dictonary[patternArray[i]]) return false;
                }
                else
                {
                    if (set.Contains(patternToCheckArray[i])) return false;


                    dictonary.Add(patternArray[i], patternToCheckArray[i]);
                    set.Add(patternToCheckArray[i]);
                }
            }
            return true;

        }
    }
}