using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibbonacciSeries
    {
        public static void Fibbonacci_Series()
        {
            int val1=0,val2=1,val3=2;
            Console.WriteLine("Enter the range for fibbonacci series");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The fibbonacci series will be:");
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            for(val3=2;val3<=number;val3++)
            {
                val3= val1 + val2;
                Console.WriteLine(val3);
                val1 = val2;
                val2= val3;
            }
        }
    }
}
