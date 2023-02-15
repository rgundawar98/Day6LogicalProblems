using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void Prime_Check()
        {
            int val = 2;
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool Is_Prime = true;
            for(val=2;val<number/2;val++)
            {
                if(number%val==0)
                {
                    Is_Prime= false;
                    break;
                }
            }
            if(Is_Prime)
            {
                Console.WriteLine("It is prime number");
            }
            else
            {
                Console.WriteLine("It is not prime number");
            }
        }
    }
}
