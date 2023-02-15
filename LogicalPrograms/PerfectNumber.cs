using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static void Display_Perfect_Number()
        {
            int val=1 , sum=0 ;
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number >1 && val<number)
            {
                if(number%val==0)
                {
                    Console.WriteLine("Value is" + val);
                    sum = sum + val;
                    val++;
                }
                else
                {
                    val++;
                }
            }
            Console.WriteLine("Perfect number will be:"+val);
        }
    }
}
