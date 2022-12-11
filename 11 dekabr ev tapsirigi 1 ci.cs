using System;

namespace _11_dekabr_ev_tapsirigi_1_ci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Verilmiş M dəyərindən verilmiş N dəyərinədək 21 - ə bölünən ədədlərin ədədi ortasını tapan proqram

            

            
            Console.WriteLine("1ci ededi daxil edin:");
            int sum = 0;
            int count = 0;
            var numMStr = Console.ReadLine();
            var numM = Convert.ToInt32(numMStr);
            Console.WriteLine("2ci ededi daxil edin:");
            var numNStr = Console.ReadLine();
            int numN = Convert.ToInt32(numNStr);


            while (numM < numN)
            {

                if (numM % 21 == 0)
                {
                    sum += numM;
                    count++;
                    numM++;

                }
                else
                {
                    numM++;
                }


            }
            if (count == 0)
            {
                Console.WriteLine("0a bolmek olmaz");
            }
            else
            {
                Console.WriteLine(sum / count);
            }







        }
    }
}
