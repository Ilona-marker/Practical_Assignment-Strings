using System;   
public class Program  
{     
    public static void Main()      
    {        
        string userInput;            
        Console.Write("Input the string : ");          
        userInput = Console.ReadLine();         
        Console.Write("The string you entered is : {0}\n", userInput);  
        ///*Find out how many letters are in the string userInput
        Console.WriteLine($"Length of the string is : {userInput.Length}");
    } 
}  