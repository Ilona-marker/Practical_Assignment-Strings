using System;   
public class Program_77  
{     
    public static void Main()      
    {        
        string[] words = {"Computer", "Plate", "Chair", "Girl",
        "Boy", "Cat", "Dog", "Shirt", "Determination" };
  /* ● Find out how many values are starting with ‘C’; 
     ● Find out how many values are ending with “e”; 
     ● Find out how many values are with length 5; 
     ● Find out how many values consist of the character “e”; 
     ● Find out is there any element which consists of the subString “te”; 
     ● Calculate a histogram of values related to length of value.*/
            int startsWithC = 0,
                endsWithE = 0,
                hasLengthFive = 0,
                containsE = 0,
                containsTe = 0,
                maxLength = 0;
        foreach (string word in words) 
        {
          if (word.StartsWith('C') || word.StartsWith('c'))
          {
            startsWithC++;  
          } 
          if (word.EndsWith('E') || word.EndsWith('e'))
          {
             endsWithE++; 
          }
          if (word.Length == 5)
          {
             hasLengthFive++; 
          }
          if (word.Contains('E') || word.Contains('e'))
          {
              containsE++;
          }
          if (word.Contains("Te") || word.Contains("te"))
          {
              containsTe++;
          } 
          if (word.Length > maxLength)
              {
                maxLength = word.Length;
              }
         }
            Console.WriteLine($"{startsWithC} words start with 'c'.");
            Console.WriteLine($"{endsWithE} words end with 'e'.");
            Console.WriteLine($"{hasLengthFive} words have 5 characters.");
            Console.WriteLine($"{containsE} words contain 'e'.");
            Console.WriteLine($"{containsTe} words contain 'te'.");
            int[] histogram = new int[maxLength + 1];
            foreach (string word in words)
            {
                histogram[word.Length]++;
            }
            for (int wordLength = 1; wordLength < histogram.Length; wordLength++)
            {
                int count = histogram[wordLength];
                Console.WriteLine($"{count} words with length {wordLength}");
            }
    }
}
  
        
        