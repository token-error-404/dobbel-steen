using System;

namespace tim
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rnd = new Random();



            string ja_of_nee = "ja";


            while (ja_of_nee == "ja")
            {

                int dobbelsteen12 = rnd.Next(1, 7);
                int dobbelsteen1 = rnd.Next(1, 7);
                int dobbelsteen2 = rnd.Next(1, 7);
                int dobbelsteen22 = rnd.Next(1, 7);


                Console.WriteLine("============");
                Console.WriteLine(" ");
                Console.Write(dobbelsteen1);
                Console.Write("-");
                Console.Write(dobbelsteen12);
                Console.WriteLine(" ");
                Console.WriteLine("........... ");
                Console.Write(dobbelsteen2);
                Console.Write("-");
                Console.WriteLine(dobbelsteen22);



                int totaal1 = dobbelsteen1 + dobbelsteen12;
                int totaal2 = dobbelsteen2 + dobbelsteen22;

                if (totaal1 > totaal2)
                {
                    Console.WriteLine("player1 wint");
                }
                if (totaal1 < totaal2)
                {
                    Console.WriteLine("player2 wint");
                }
                if (totaal1 == totaal2)
                {
                    Console.WriteLine("GelijKSPEL");
                }

                Console.WriteLine("nog eens ja of nee ?: "); ja_of_nee = Console.ReadLine(); Console.WriteLine("je hebt ge kozen voor, {0}", ja_of_nee);

            }
            if (ja_of_nee == "nee")
            {
                Console.WriteLine("==========================");
                Console.WriteLine("=gemaakt door tim.maessen=");
                Console.WriteLine("==========================");
                Console.WriteLine("   ");
                Console.WriteLine("=============================");
                Console.WriteLine("druk op enter om te sluiten");
                Console.WriteLine("=============================");
            }






        }
    }
}
