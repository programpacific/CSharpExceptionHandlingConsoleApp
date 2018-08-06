using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExceptionHandlingConsoleApp

     //    IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
    //1. Ask the user for his age.
   //2. Display the year user born.
  //3. Exceptions must be handled using "try .. catch".
 //4. Display appropriate error messages if user enters zero or negative numbers.
//5. Display a general message if exception caused by anything else.


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

                Console.Write("How old are you?: ");
                age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    throw new SpecialExceptions();
                }

                int birthYear = currentYear - age;

                Console.Write("\nCurrent Year: {0}\nBirth Year: {1}\n\nPress enter to exit!", currentYear, birthYear);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("\nYou've input an invalid response, please contact your system administrator.\n\n" +
                    "Thank you for demoing my application! Press enter to exit!");
                Console.ReadLine();
            }            
        }
    }
}
