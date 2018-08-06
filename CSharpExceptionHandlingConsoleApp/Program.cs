using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExceptionHandlingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = 0;
                int currentYear = Convert.ToInt32(DateTime.Today.Year.ToString());

                Console.Write("Welcome to the Birth Year Calculator!\n\n");

                Console.Write("How old are you?:");
                age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    throw new SpecialExceptions();
                }

                int birthYear = currentYear - age;

                Console.Write("Current Year: {0}\n\nBirth Year: {1}\n\nPress enter to exit!", currentYear, birthYear);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("\nYou've input an invalid response, please contact your system administrator.\n\n" +
                    "Press enter to exit!");
                Console.ReadLine();
            }            
        }
    }
}
