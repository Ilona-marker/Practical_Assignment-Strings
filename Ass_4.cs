using System;   
using System.Text.RegularExpressions;
public class Program_4  
{     
    public static void Main(string[] args)      
    {   
      /*● Create a String variable name with the value “John” and*/ 
      string name = "John"; 
      /*create a regex pattern for that (only letters are allowed). 
      Try to test it using IsMatch function*/ 
      Regex nameRegex = new Regex("^[A-Za-z]+$");
      bool nameIsValid = nameRegex.IsMatch(name);
      Console.WriteLine("Name is valid: " + nameIsValid);
      /*● Create a String variable username with the value “s20surname” 
        and create a regex pattern for that (the first is a letter, after that 2 digits 
        are allowed and after that unlimited letters are allowed). 
        Try to test it using IsMatch function*/
       string username = "s20surname";
       /*проверяем,чтоб у нас были первое число,даьше 2 цифы(может и одна или две,дале снова буквы*/
       Console.WriteLine("Username is valid: " + Regex.IsMatch(username, "^[A-Za-z]([0-9]{2})?[A-Za-z]*$"));
      /*● Create a String variable personCodeOfLatvian with the value “121200-11311” 
        and create a regex pattern for that (6 digits, after that - sign, after that 5 digits). 
        Try to test it using IsMatch function*/
       string personCodeOfLatvian = "121200-11311";
        /*проверяем 6 цифр - далее тире - далее 5 цифр*/
       Console.WriteLine("Person code is valid: " + Regex.IsMatch(personCodeOfLatvian, "^[0-9]{6}-[0-9]{5}$"));
       /*другим способом*/
       Regex personCodeRegex = new Regex("^([0-9]{6}-[0-9]{5})$");
       Match match = personCodeRegex.Match(personCodeOfLatvian);
       if ( !match.Success)
       {
           Console.WriteLine("Person code is valid : False");
       }
           Console.WriteLine("Person code is valid : True");
        
        //это для персональных индивидуальных(новых)кодов,когда просто цифры
        //Jaunā personas koda pirmie cipari ir "32", bet pārējie cipari 
        //ir automātiski sistēmas ģenerētie nejaušie cipari no "0" līdz "9".

            if (!match.Success)
            {
                Console.WriteLine("Person code is valid: False");
            }
            else
            {
               Console.WriteLine("Person code is valid: True");
            }
    }
}

       
        