using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Programs");
            Console.WriteLine("1.Fibbonacci Series\n2.Perfect Number\n3.PrimeNumber");
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
            }
        }
    }
}
