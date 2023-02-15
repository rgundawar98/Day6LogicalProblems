using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Calulate_StopWatch
    {
        public static void Display_Stopwatch()
        {
            long Clicks = 0;
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            Clicks = sw.ElapsedTicks;
            sw.Stop();
            Console.WriteLine("The elapsed time is:"+Clicks);
        }
    }
}
