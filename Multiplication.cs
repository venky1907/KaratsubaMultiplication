using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaratsubaMultiplication
{
    public class Multiplication
    {
        public double val = 0;
        public double Karatsuba(double number1, double number2, int no_of_digits)
        {
            //double digi1 = number1 / 10;
            //double digi2 = number2 / 10;

            Console.WriteLine(String.Format("The number is {0} and {1}", number1, number2));
            if ( no_of_digits == 1) 
            {
              

                if (number1 == 0 || number2 == 0)
                {
                    return 0;
                }
                val++;
                return (number1 * number2);
            }

            //int myfactor = no_of_digits / 2;
            double powerfactor = no_of_digits / 2;
            powerfactor = Math.Ceiling(powerfactor);
            double factor = Math.Pow(10, powerfactor);
            double a = number1 / factor;
            double c = number2 / factor;

            double b = number1 % factor;
            double d = number2 % factor;


            a = Math.Truncate(a);
            b = Math.Truncate(b);
            c = Math.Truncate(c);
            d = Math.Truncate(d);


            double total = (Math.Pow(10, no_of_digits) * Karatsuba(a, c, no_of_digits / 2))
                + (Math.Pow(10, no_of_digits / 2) * (Karatsuba(a, d, no_of_digits / 2) + Karatsuba(b, c, no_of_digits / 2)))

              + (Karatsuba(b, d, no_of_digits / 2));


       

            Console.WriteLine(String.Format("Sum for numbers {0} and {1} is {2} ", number1, number2, total));
            return total;
        }

    }
}
