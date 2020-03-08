using System.Collections.Generic;
using System.Linq;

namespace StringEvaluator
{
    public class StringEvaluator
    {
        public static bool IsProperBraces(string input)
        {
            var letterStack = new Stack<char>();
            var openBraces = new Dictionary<char, char> { { '{', '}' }, { '[', ']' }, { '(', ')' } };

            foreach(var letter in input)
            {
                if(openBraces.ContainsKey(letter))
                {
                    letterStack.Push(letter);
                }
                else if (openBraces.ContainsValue(letter) && letter == openBraces.GetValueOrDefault(letterStack.Peek()))
                {
                    letterStack.Pop();
                }
                else if (openBraces.ContainsValue(letter) &&  letter != openBraces.GetValueOrDefault(letterStack.Peek()))
                {
                    return false;
                }
            }

            if(letterStack.Any())
            { 
                return false;
            }

            return true;
        }
    }
}
