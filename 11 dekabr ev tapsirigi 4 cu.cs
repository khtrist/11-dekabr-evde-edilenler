using System;
using System.Diagnostics.Tracing;

namespace _11_dekabr_ev_tapsirigi_3
{
    internal class
    {
        private static void Main(string[] args)
        {
            // Verilmiş yazıda rəqəm olmamasını yoxlayan proqram,
            // əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək.
            Console.WriteLine("Yazini daxil edin");
            var soz = Console.ReadLine();
            
            char char1 = '1';
            char char2 = '2';
            char char3 = '3';
            char char4 = '4';
            char char5 = '5';
            char char6 = '6';
            char char7 = '7';
            char char8 = '8';
            char char9 = '9';
            char char0 = '0';

            for (int i = 0; i < soz.Length; i++)
            {
                for (int j = 0; j < soz.Length; j++)
                {

                    if (char0 == soz[i])
                    {
                        Console.WriteLine("Sozde (0) Reqemi var ")
                            ; break;
                    }

                    if (char1 == soz[i])
                    {
                        Console.WriteLine("Sozde (1) Reqemi var ")
                            ; break;
                    }

                    if (char2 == soz[i])
                    {
                        Console.WriteLine("Sozde (2) Reqemi var ")
                            ; break;
                    }

                    if (char3 == soz[i])
                    {
                        Console.WriteLine("Sozde (3) Reqemi var ")
                            ; break;

                    }


                    if (char4 == soz[i])
                    {
                        Console.WriteLine("Sozde (4) Reqemi var ")
                            ; break;
                    }


                    if (char5 == soz[i])
                    {
                        Console.WriteLine("Sozde (5) Reqemi  var ")
                            ; break;
                    }


                    if (char6 == soz[i])
                    {
                        Console.WriteLine("Sozde (6) Reqem var ")
                            ; break;
                    }


                    if (char7 == soz[i])
                    {
                        Console.WriteLine("Sozde (7) Reqem var ")
                            ; break;
                    }



                    if (char8 == soz[i])
                    {
                        Console.WriteLine("Sozde (8) Reqem var ")
                            ; break;
                    }


                    if (char9 == soz[i])
                    {
                        Console.WriteLine("Sozde (9) Reqem var ")
                            ; break;
                    }

                    else
                    {
                        break;
                    }
                }

                


            }



            
        }
    }
}
