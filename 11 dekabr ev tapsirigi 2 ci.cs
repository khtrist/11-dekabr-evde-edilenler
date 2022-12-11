using System;

namespace _11_dekabr_ev_tapsirigi_2_ci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ədədin rəqəmləri cəmini tapan proqram
            
            
            Console.WriteLine("Ededi daxil edin ");
            int num,
            sum = 0,
                t;
            var numStr = Console.ReadLine();
            var numNum = Convert.ToInt32(numStr);
            while (numNum != 0)
            {
                t = numNum % 10;
                numNum = numNum / 10;
                sum =sum + t;
            }
            Console.WriteLine("Ededin reqemlerinin cemi : " + sum);
            

            
            //Console.WriteLine("Ededi daxil edin");
            

            

        }



    }
}
