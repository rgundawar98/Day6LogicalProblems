using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static void Display_Reverse_Number()
        {
            int remainder = 0, reverse = 0;
            Console.WriteLine("Enter the number to be reversed");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number != 0)
            {
                remainder = number % 10;
                reverse = (reverse* 10) + remainder;
                number = number / 10;
                Console.WriteLine("Number:{0} and remainder:{1} and reverse:{2}", number, remainder, reverse);
            }
        }
    }
}
