using System;

namespace _11_dekabr_ev_tapsirigi_2_ci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Verilmiş ayın ədədinə görə fəsil olduğunu tapan proqram=======================
            //Console.WriteLine("Ayı Daxil Edin");
            Console.WriteLine("Ayı Daxil Edin");
            var MonthStr = Console.ReadLine();
            var monthNum = Convert.ToInt32(MonthStr);
            if ((monthNum < 1) || (monthNum > 12))
            {
                Console.WriteLine("Duzgun deyl");
            }


            if (monthNum == 12 || monthNum == 1 || monthNum == 2)
            {
                Console.WriteLine("Qis");
            }
            if (monthNum == 3 || monthNum == 4 || monthNum == 5)
            {
                Console.WriteLine("YAZ");
            }
            if (monthNum == 6 || monthNum == 7 || monthNum == 8)
            {
                Console.WriteLine("YAY");
            }
            if (monthNum == 9 || monthNum == 10 || monthNum == 11)
            {
                Console.WriteLine("PAYIZ");








            }
        }
    }
}
