using System;
using System.Collections;
using System.Collections.Generic;

namespace GenerateParentheses
{


    public class ParenthesesGenerator
    {
        public static void Main(string[] args)
        {
            //tese Case 1 
            int n = 3;
            var result = AllParenthesis(n);
            Console.WriteLine($"All valid combinations of {n} pairs of parentheses:");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        private static void Generate(int open, int close, List<string> ans, string str)
        {
            // (3,3,{} , "")
            if (open == 0 && close == 0)
            {
                ans.Add(str);
                return;
            }
            if (open != 0)
            {
                Generate(open - 1, close, ans, str + "(");
            }
            if (close > open)
            {
                Generate(open, close - 1, ans, str + ")");
            }
        }

        public static List<string> AllParenthesis(int n) //1
        {
            List<string> ans = new List<string>(); // { } 
            Generate(n, n, ans, ""); // (1,1,{} , "")
            return ans;  // 
        }
    }


}
