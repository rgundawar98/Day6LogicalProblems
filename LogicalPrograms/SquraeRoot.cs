using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class SquraeRoot
    {
        public static void Check_Square_Root()
        {
            Console.WriteLine("Enter the value");
            double value = Convert.ToDouble(Console.ReadLine());
            double t =value, epsilon = 1e-15;
            while(Math.Abs(t-value/t)> epsilon*t)
            {
                t =(value/t + t)/2.0;
                Console.WriteLine("Square root number is"+t);
            }
        }
    }
}
