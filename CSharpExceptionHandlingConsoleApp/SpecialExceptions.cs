using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExceptionHandlingConsoleApp
{
    public class SpecialExceptions : Exception
    {
        public SpecialExceptions()
        {
            Console.WriteLine("\n\nThat is a negative or invalid number!\n\n");
        }
    }
}
