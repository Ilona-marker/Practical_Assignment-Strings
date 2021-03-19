using System;   
public class Program_6  
{     
    public static void Main()      
    {        
        string userInput;   
        int inputLength;   
        Console.Write("Input the string : ");          
        userInput = Console.ReadLine();         
        Console.Write("The string you entered is : {0}\n", userInput);
        /*Print individual characters of the string in reverse order. 
        a. Expected Output: !ecnetnes ym si siht ,olleH */
        inputLength = userInput.Length - 1;    
        Console.Write("The characters of the string in reverse are: \n");    
        while (inputLength >= 0)             
        {                 
            Console.Write("{0} ", userInput[inputLength]);                 
            inputLength --;             
        }          
    }
}      