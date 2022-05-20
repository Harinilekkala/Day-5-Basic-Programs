using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalprograms
{
    internal class quotientandremainder
    {
        public static void Main(string[] args)
        {

            int dividend = 50, divisor = 8;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Compute Quotient and Dividend");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
