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
            string patternToCheck = "dog dog dog dog";
            Patterns patterns = new Patterns();
            bool result = patterns.FindPattern(pattern, patternToCheck);
            Console.WriteLine("result  : " + result);
        }
    }
}
