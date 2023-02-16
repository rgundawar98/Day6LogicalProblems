using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumber
    {
        public static void Check_Coupon_Number(int CouponNumber)
        {
            Console.WriteLine("Enter the distinct coupon number");
            CouponNumber = Convert.ToInt32(Console.ReadLine());
            int distinct=0 ,count=0;
            bool[] isCollected = new bool[CouponNumber];
            int[] Coupons = new int[CouponNumber];
            while(distinct < CouponNumber)
            {
                Random random= new Random();
                int newRandom = Convert.ToInt32(random.Next(0,CouponNumber));
                count++;
                if (!isCollected[newRandom])
                {
                    distinct++;
                    isCollected[newRandom] = true;
                    Coupons[newRandom] = newRandom;
                    Console.WriteLine(Coupons[newRandom]);
                }
            }
            Console.WriteLine("Total random number needed to have all distinct count :"+count);
        }
    }
}
