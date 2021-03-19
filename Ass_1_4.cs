using System;

namespace SGT_DotNet5_Examples
{
    class Program_4
    {
      static void Main(string[] args)
       {                   
        Console.Write("Input the string : ");          
        string userInput = Console.ReadLine();         
        Console.Write("The string you entered is : {0}\n", userInput);
        //Try to count the total number of words in a string and print the result 
        string[] words = userInput.Split(" ");
        Console.WriteLine($"The total number of words are: {words.Length}");
       }   
    }        
}