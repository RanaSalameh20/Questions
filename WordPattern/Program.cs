using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "aaaa";
            string s = "dog dog dog dog";
            bool res = WordPattern(pattern, s);
            Console.WriteLine("res  : " + res);
        }
        public static bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            HashSet<string> set = new HashSet<string>();

            char[] pArray = pattern.ToCharArray();  // [a,b,b,a]

            string[] sArray = s.Split(' ');  // [dog,cat , cat , dog ]


            if (pattern.Length != sArray.Length) return false;
            for (int i = 0; i < pArray.Length; i++)
            {
                if (dict.ContainsKey(pArray[i]))
                {
                    if (sArray[i] != dict[pArray[i]]) return false;
                }
                else
                {
                    if (set.Contains(sArray[i])) return false;


                    dict.Add(pArray[i], sArray[i]);
                    set.Add(sArray[i]);
                }
            }
            return true;

        } 
    }
}
