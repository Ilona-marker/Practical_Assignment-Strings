using System;
using System.Text.RegularExpressions;

namespace SGT_DotNet5_Examples
{
    class Program_22
    {
        static void Main(string[] args)
        {
         
        // ● Create a String variable `personCodeOfLatvian` with the value “121200-11311”
         //это для персональных индивидуальных(новых)кодов,когда просто цифры
        //Jaunā personas koda pirmie cipari ir "32", bet pārējie cipari 
        //ir automātiski sistēmas ģenerētie nejaušie cipari no "0" līdz "9".
            string personCodeOfLatvian = "32123456789";
            // create a regex pattern for that (6 digits, after that - sign, after that 5 digits).
            Regex personCodeRegex = new Regex("^([0-9]{6})-([0-9]{5})$");
            Match match = personCodeRegex.Match(personCodeOfLatvian);
            if (!match.Success)
            {
                Console.WriteLine("Person code is valid: False");
            }
            else
            {
                int[] pk = new int[11];
                for (int i = 0; i < pk.Length; i++)
                {
                    pk[i] = personCodeOfLatvian[i < 6 ? i : (i + 1)] - '0';
                }

                int day = pk[0] * 10 + pk[1];
                /*int month = pk[2] * 10 + pk[3];
                int century = (18 + pk[6]) * 100;
                int year = century + pk[4] * 10 + pk[5];*/

                if (day == 32)
                {
                    Console.WriteLine("New series personal code");
                }
                else
                {
                    // TODO Check if day+month+year are reasonable.
                }

                int checksum = (1101 - (1 * pk[0] + 6 * pk[1] + 3 * pk[2] + 7 * pk[3] +
                    9 * pk[4] + 10 * pk[5] + 5 * pk[6] + 8 * pk[7] + 4 * pk[8] + 2 * pk[9])) % 11;

                Console.WriteLine("Person code is valid: " + (checksum == pk[10]));
            }
        }
    }
}
