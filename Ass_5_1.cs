using System;
using System.Text.RegularExpressions;

namespace SGT_DotNet5_Examples
{
    class Program_224
    {
        static void Main(string[] args)
        {
  //Write a program where the verification of the palindrome is provided. 
  //Palindrome is the sentence which reads the same backward as forward         
  //● Create the algorithm which will process the sentence and return the result - is this sentence a palindrome or not. 
  //● Testing palindrome sentences:  b. Was it a car or a cat I saw?  
          Regex nonLetters = new Regex("[^A-Za-z]");
          string input = "Was it a car or a cat I saw?"; 
          bool isPalindrome = true;
          string lowerInput = nonLetters.Replace(input, "").ToLower(); 
          // делаем все буквы прописными .ToLower()
          //а также избавляемся при помощи .Replace(input, "") от вех пробелов и знаков препинания
          //получаем lowerInput ="wasitacaroracatIsaw"
          for (int i = 0; i < lowerInput.Length / 2; i++ ) //делим на 2,чтобы слово поделить пополам по центру
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

        