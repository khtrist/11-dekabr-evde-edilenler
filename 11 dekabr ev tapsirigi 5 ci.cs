using System;
using System.Diagnostics.CodeAnalysis;

namespace _10_dekabr_ikinci_cetin_axrinci
{
    internal class Program
    {
        private static int i;
        private static int length;

        static void Main(string[] args)
        {



            //Verilmiş 2 ədəd üzərində verilmiş operator simvoluna uyğun riyazi əməliyyat aparan proqram.
            //Misalçün consoledan 5,10 və + daxil edilsə 5 və 10-u toplayıb nəticəsini göstərsin.Console-dan daxil edilən operator + , -, *, / 
            //operatorlarından biri deyilsə operator yanlışdır yazılsın.

            int x;
            int y;
            char emeliyyat;

            Console.Write("Birinci ededi daxil edin: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Emeliyyati daxil edin: ");
            emeliyyat = Convert.ToChar(Console.ReadLine());
            Console.Write("Ikinci ededi daxil edin: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (emeliyyat == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (emeliyyat == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((emeliyyat == 'x') || (emeliyyat == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (emeliyyat == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Netice");







        }
    }
}
