using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public static void Check_Monthly_Payment()
        {
            Console.WriteLine("Enter the Principal");
            double principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate");
            double Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            double year= Convert.ToInt32(Console.ReadLine());
            double r = Rate / (12 * 100);
            double n = 12 * year;
            double payment = principal * r / (1 - Math.Pow((1 + r), -n));  
            Console.WriteLine("Payment will be:"+payment);
        }
    }
}
