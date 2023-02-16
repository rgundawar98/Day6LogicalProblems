using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class TemperatureConversion
    {
        public static void Temperature()
        {
            int Farhenit = 0, Celsius = 0 , Cels=0, Farh=0;
            Console.WriteLine("Enter the Celsius");
            Cels = Convert.ToInt32(Console.ReadLine());
            Farhenit = ((Cels * 9 / 5) + 32);
            Console.WriteLine("Farhenit value will be:"+Farhenit);
            
            Console.WriteLine("Enter Farhenit temperature");
            Farh = Convert.ToInt32(Console.ReadLine());
            Celsius = ((Farh - 32) * 5 / 9);
            Console.WriteLine("Celsius value will be:"+Celsius);
        }
    }
}
