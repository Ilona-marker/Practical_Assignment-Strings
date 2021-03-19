using System;
using System.Text.RegularExpressions;

namespace SGT_DotNet5_Examples
{
    class Program_33
    {
        static void Main(string[] args)
        {
            Regex nonLetters = new Regex("[^A-Za-z]");

            string[] inputs = {
                "Mom",
                "Was it a car or a cat I saw?",
                "Madam, in Eden, I’m Adam.",
                "Yo, banana boy!",
                "Failure condition."
            };

            foreach (string input in inputs)
            {
                bool isPalindrome = true;
                string lowerInput = nonLetters.Replace(input, "").ToLower();
                for (int i = 0; i < lowerInput.Length / 2; i++)
                {
                    int leftIndex = 0 + i;
                    char left = lowerInput[leftIndex];

                    int rightIndex = (lowerInput.Length - 1) - i;
                    char right = lowerInput[rightIndex];

                    if (left != right)
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine($"{input} : {isPalindrome}");
            }
        }
    }
}
