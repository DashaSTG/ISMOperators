using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorsLibrary;

namespace oopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(5, 7);
            Fraction b = new Fraction(2, 3);
            Fraction c = new Fraction(1.5);

            Fraction result;
            if (a < b)
            {
             result = a + b + 2;
            }
            else
            {
                result = a * b - 3;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
