using System;

class Program_33
{
     static void Main(string[] args)
    { 
       // DateTime, UniversalTime ;
      // Try to ask the user to write the day, month and year of the birthday in the console.
      Console.Write("Please enter birthday day: ");
      int day;
        while (!Int32.TryParse(Console.ReadLine(), out day) || day < 0 || day > 31)
        {
         Console.Write("Invalid input! Please enter day: ");
        }
        Console.Write("Please enter birthday month: ");
        int month;
        while (!Int32.TryParse(Console.ReadLine(), out month) || month < 0 || month > 12 )
        {
            Console.Write("Invalid input! Please enter month: ");
        }
        Console.Write("Please enter birthday year: ");
        int year;
        while (!Int32.TryParse(Console.ReadLine(), out year) || year < 1945)
        {
            Console.Write("Invalid input! Please enter year: ");
        }
         //Read all values and create a DateTime objects and print out these in the console.
          DateTime birthday = new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Local);
          Console.WriteLine($"Birthday is: {birthday}");
          Console.WriteLine($"Birthday is: {birthday.Kind}");   
          Console.WriteLine($"UTC is: {birthday.ToUniversalTime()}");
    }
} 


