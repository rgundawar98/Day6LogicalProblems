using System;
using System.Numerics;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Programs");
            Console.WriteLine("1.Fibbonacci Series\n2.Perfect Number\n3.PrimeNumber\n4.ReverseNumber\n6.Calulate StopWatch" +
                "\n8.DayOfWeek\n9.Temperature Conversion\n10.MonthlyPayment\n11.SquraeRoot");
            Console.WriteLine("Choose option from above");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FibbonacciSeries.Fibbonacci_Series();
                    break;
                case 2:
                    PerfectNumber.Display_Perfect_Number();
                    break;
                case 3:
                    PrimeNumber.Prime_Check();
                    break;
                case 4:
                    ReverseNumber.Display_Reverse_Number();
                    break;
                case 6:
                    Calulate_StopWatch.Display_Stopwatch();
                    break;
                case 8:
                    DayOfWeek.Check_Day_Of_Week();
                    break;
                case 9:
                    TemperatureConversion.Temperature();
                    break;
                case 10:
                    MonthlyPayment.Check_Monthly_Payment();
                    break;
                case 11:
                    SquraeRoot.Check_Square_Root();
                    break;
            }
        }
    }
}
