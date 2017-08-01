using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deleg1
{
    class Program
    {
        delegate double Multiply(double a, double b, bool y);

        public static double Mult(double a, double b, bool y)
        {
            if (y)
            {
                Console.WriteLine("Умножение");
                return a * b;
            }
            else 
            {
                Console.WriteLine("Сумма");
                return a + b;
            }
            
        }
        static void Main(string[] args)
        {
            Multiply M;
            M = Mult;
            Console.WriteLine(M(45.3,34.7,true));
           
        }
    }
}
