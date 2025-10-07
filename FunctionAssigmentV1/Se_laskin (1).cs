namespace sevittunlaskin
{
    using System;

    namespace Laskin
    {
        class Program
        {

            static double num1;
            static double num2;


            static void Main(string[] args)
            {



                int valinta()
                {


                    Console.WriteLine("Tervetuloa laskimeen!");

                    Console.Write("Anna ensimmäinen luku: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Anna toinen luku: ");
                    num2 = Convert.ToDouble(Console.ReadLine());


                    return 0;


                }




                static int valinta2()
                {

                    Console.WriteLine("Valitse toiminto:");
                    Console.WriteLine("\t1. Plus");
                    Console.WriteLine("\t2. Miinus");
                    Console.WriteLine("\t3. Kertolasku");
                    Console.WriteLine("\t4. Jakolasku");
                   

                    switch (Console.ReadLine())
                    {


                        case "1":
                            Console.WriteLine("Tulos: " + (num1 + num2));
                            break;
                        case "2":
                            Console.WriteLine("Tulos: " + (num1 - num2));
                            break;
                        case "3":
                            Console.WriteLine("Tulos: " + (num1 * num2));
                            break;
                        case "4":
                            Console.WriteLine("Tulos: " + (num1 / num2));
                            break;
                        default:
                            Console.WriteLine("Virheellinen valinta");
                            break;







                           


                    }   

                      return 0;








                }










                valinta();
                valinta2();



            }
        }
    }
}