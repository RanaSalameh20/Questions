using System;
using System.Collections;
using System.Collections.Generic;

namespace GenerateParentheses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //tese Case 1 
            ParenthesesGenerator paranthesesGenerator = new ParenthesesGenerator();
            int numberOfParantheses = 3;
            var combinations = paranthesesGenerator.CreateAllParenthesis(numberOfParantheses);
            Console.WriteLine($"All valid combinations of {numberOfParantheses} pairs of parentheses:");
            foreach (var combination in combinations)
            {
                Console.WriteLine(combination);
            }
        }
     
    }
}
