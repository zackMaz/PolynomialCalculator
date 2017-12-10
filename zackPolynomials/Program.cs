using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zackPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a polynomial. No spaces.");
            string polynomial = Console.ReadLine();
        }

        static double FracToDouble(string fraction)
        {
            double value;

            if (double.TryParse(fraction, out value))
            {
                return value;
            }

            string[] split = fraction.Split(new char[] { '/' });

            if (split.Length > 1)
            {
                int a, b;


                if (int.TryParse(split[0], out a) && int.TryParse(split[1], out b))
                {
                    return (double)a / b;
                }
            }


            throw new FormatException("Not a valid fraction. Mixed fractions do not work.");
        }
    }
}
