using System;   
using System.Text.RegularExpressions;
public class Program_5  
{     
    public static void Main()      
    {        
      string sentence = "Climb mountains not so the world can see you, but so you can see the world";
      /*Print out how many words are in the sentence; 
      ● Find out how many “the” words are in the sentence
        (use also the variant of Regex.Matches);
      ● Find out how many words consists of the letter “s”; 
      ● Find out the words that are repeated in the sentence multiple times. 
        For example, see, you, can, so, the; 
      ● Change the word “you” to “You”. Print out the new sentence.*/   
      string[] words = sentence.Split(" ");
      int containS = 0;
      int theWords = 0;
      Console.WriteLine($"The total number of words are: {words.Length}");
      Console.WriteLine($"There are {Regex.Matches(sentence, " the ").Count} 'the' words.");
       foreach (string word in words)
            {
                if (word.Contains('s') || word.Contains('S'))
                {
                    containS++;
                }
                if (word.Equals("the"))
                {
                    theWords++;
                }
            }
            Console.WriteLine($"There are {containS} words containing 's'.");
            Console.WriteLine($"There are {theWords} 'the' words");

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    string wordA = words[i];
                    string wordB = words[j];

                    if (wordA.Equals(wordB))
                    {
                        Console.WriteLine($"{wordA} is repeated!");
                    }   
                }  
            }    
            Console.WriteLine(sentence.Replace("you", "You")); 
    }
}     