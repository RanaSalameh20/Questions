using System.Collections.Generic;

namespace GenerateParentheses
{
    public class ParenthesesGenerator
    {
        public List<string> CreateAllParenthesis(int numberOfParantheses) 
        {
            List<string> result = new List<string>();
            Generate(numberOfParantheses, numberOfParantheses, result, "");
            return result; 
        }
        private void Generate(int open, int close, List<string> result, string combination)
        {    
            if (open == 0 && close == 0)
            {
                result.Add(combination);
                return;
            }
            if (open != 0)
            {
                Generate(open - 1, close, result, combination + "(");
            }
            if (close > open)
            {
                Generate(open, close - 1, result, combination + ")");
            }
        }
    }
}