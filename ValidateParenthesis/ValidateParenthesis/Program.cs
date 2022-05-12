using System;
using System.Collections.Generic;

namespace ValidateParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidParentheses validParentheses = new ValidParentheses();
       
            Console.WriteLine(validParentheses.IsValidReview("(Hello world)")); // true
            Console.WriteLine(validParentheses.IsValidReview("()[]{}")); // true
            Console.WriteLine(validParentheses.IsValidReview("(]")); // false
            Console.WriteLine(validParentheses.IsValidReview("([)]")); // false
            Console.WriteLine(validParentheses.IsValidReview("{[]}")); // true
            Console.WriteLine();
        }

        public class ValidParentheses
        {
            public bool IsValidReview(string s)
            {
                Stack<char> endings = new Stack<char>();

                foreach (var curr in s)
                {
                    switch (curr)
                    {
                        case '(':
                            endings.Push(')');
                            break;
                        case '[':
                            endings.Push(']');
                            break;
                        case '{':
                            endings.Push('}');
                            break;
                        case ')':
                        case ']':
                        case '}':
                            if (endings.Count == 0 || endings.Pop() != curr)
                                return false;
                            break;

                    }
                }

                return endings.Count == 0;
            }
        }
    }
}
