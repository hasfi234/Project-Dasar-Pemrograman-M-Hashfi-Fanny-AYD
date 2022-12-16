using System;

namespace UTS4PermainanSuit
{
    class Program
    {
        static int poinMenang;
        static int poinKalah;
        static int poinSeri;
        static bool gamePlay;
        static Random pilihan = new Random();

        static void Main(string[]args)
        {
            gamePlay = true;
            while (gamePlay)
            {
                Console.Clear();
                Console.WriteLine("batu, Gunting, kertas");
                Console.Write("\nPilih [b]atu, [g]unting, [k]ertas, or [e]xit : ");

                string pilihanPlayer = Console.ReadLine();
                if(pilihanPlayer == "e")
                {
                    break;
                }

                int pilihanKomputer = pilihan.Next(0,3);
                if(pilihanKomputer == 0)
                {
                    Console.WriteLine("Komputer memilih batu.");
                    switch (pilihanPlayer)
                    {
                        case"b":
                         Console.WriteLine("Seri");
                         poinSeri++;
                         break;
                         case"g":
                         Console.WriteLine("Anda Kalah");
                         poinKalah++;
                         break;
                        case"k":
                         Console.WriteLine("Anda Menang");
                         poinMenang++;
                         break;
                    }
                }
                else if(pilihanKomputer == 1)
                {
                    Console.WriteLine("Komputer memilih gunting.");
                    switch (pilihanPlayer)
                    {
                        case"b":
                         Console.WriteLine("Anda Menang");
                         poinMenang++;
                         break;
                         case"g":
                         Console.WriteLine("Seri");
                         poinSeri++;
                         break;
                        case"k":
                         Console.WriteLine("Anda Kalah");
                         poinKalah++;
                         break;
                    }
                }
                else
                {
                    Console.WriteLine("Komputer memilih kertas.");
                    switch (pilihanPlayer)
                    {
                        case"b":
                         Console.WriteLine("Anda Kalah");
                         poinKalah++;
                         break;
                         case"g":
                         Console.WriteLine("Anda menang");
                         poinMenang++;
                         break;
                        case"k":
                         Console.WriteLine("Seri");
                         poinSeri++;
                         break;
                    }
                }
                Console.WriteLine($"Skor : {poinMenang} menang, {poinKalah} kalah, {poinSeri} seri");
                Console.WriteLine("Tekan enter untuk melanjutkan permainan...");
                while(Console.ReadKey().Key != ConsoleKey.Enter)
                {
                   Console.Clear();
                   gamePlay = true;
                }

            }
        }
    }
}
