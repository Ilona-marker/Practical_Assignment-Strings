using System;   
public class Program_1  
{     
    public static void Main()      
    {        
        string userInput;  
        int inputLength = 0;          
        Console.Write("Input the string : ");          
        userInput = Console.ReadLine();         
        Console.Write("The string you entered is : {0}\n", userInput);  
        /*Find out how many letters are in the string userInput 
        (you can use a loop to count char characters in userInput string)*/
        foreach (char chr in userInput)        
         {             
             inputLength += 1;         
             }
        Console.WriteLine($"Length of the string is : {inputLength}");
    } 
}  