using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class BinaryToDecimal
    {
        public static void Check_Binary_To_Decimal()
        {
            int num = 0, Binaryval = 0, Decimalval = 0, baseval = 1, remainder = 0;
            Console.WriteLine("Enter binary number to convert into decimal");
            num=Convert.ToInt32(Console.ReadLine());
            Binaryval = num;
            while(num>0)
            {
                remainder = num % 10;
                Decimalval = Decimalval + remainder * baseval;
                num = num/ 10;
                baseval = baseval * 2;
            }
            Console.WriteLine("Binary value is:"+Binaryval);
            Console.WriteLine("Decimal value is:" + Decimalval);
        }
    }
}
