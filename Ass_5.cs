using System;
using System.Text.RegularExpressions;

namespace SGT_DotNet5_Examples
{
    class Program_223
    {
        static void Main(string[] args)
        {
  //Write a program where the verification of the palindrome is provided. 
  //Palindrome is the sentence which reads the same backward as forward         
  //● Create the algorithm which will process the sentence and return the result - is this sentence a palindrome or not. 
  //● Testing palindrome sentences: a. Mom   
          string input = "Mom"; //только 3 буквы
          bool isPalindrome = true;

          string lowerInput = input.ToLower(); // "mom" делаем все буквы прописными
          for (int i = 0; i < lowerInput.Length; i++ )
           {
              if (lowerInput[i] != lowerInput[lowerInput.Length - 1 - i] )
              {
                  isPalindrome = false;
                  break;
              }
           }
             Console.WriteLine($"{input} is polindrom : {isPalindrome} ");
        }
    }
}