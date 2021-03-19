using System;

namespace SGT_DotNet5_Examples
{
    class Program
    {
      static void Main(string[] args)
       {       
         Console.Write("Input the string : ");          
         string userInput = Console.ReadLine();         
         Console.Write($"The string you entered is : {userInput}");
         /*Print individual characters of the string in reverse order. 
         a. Expected Output: !ecnetnes ym si siht ,olleH */    
         Console.Write("The characters of the string in reverse are: \n");
         int inputLength = userInput.Length; 
         for (int i = userInput.Length - 1; i >= 0; i--)
         {
            Console.Write($"{userInput[i]} ");
         }
       }
    }
}