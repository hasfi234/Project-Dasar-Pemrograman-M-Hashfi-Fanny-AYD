//M Hashfi Fanny AYD (2207112576)

using System;
using System.Collections.Generic;

namespace TebakKata
{
    class Program
    {
        static int kesempatan = 5;
        static String kataMisteri = "METAVERSE";
        static List<string> tebakanPemain = new List<string> { };
        static bool GameStart;

        static void Main(string[] args)
        {
            Intro();
            playGame();
            showEnd();
        }

        static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Selamat datang di permainan TEBAK KATA!!");
            Console.WriteLine($"Kamu punya {kesempatan} kesempatan untuk menebak kata misteri hari ini");
            Console.WriteLine("Petunjuknya adalah...");
            Console.Write("...");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b\b\b\b");
            Console.WriteLine("|sebutan untuk konsep dunia virtual yang dapat ditinggali layaknya dunia nyata|");
            Console.Write("...");
            System.Threading.Thread.Sleep(1500);
            Console.Write("\b\b\b\b");
            Console.WriteLine($"Kata tersebut terdiri dari {kataMisteri.Length} huruf");
            Console.Write("...");
            System.Threading.Thread.Sleep(1500);
            Console.Write("\b\b\b\b");
            Console.WriteLine("Kata apakah yang dimaksud??");
            Console.WriteLine("___________________________________________________________________________________");
            Console.WriteLine("\nTekan tombol apapun untuk mulai bermain...");
            Console.ReadKey();
        }

        static void playGame()
        {
            while (kesempatan > 0)
            {
                Console.Write("\nSilahkan masukkan huruf tebakanmu!! (A - Z) : ");
                string Input = Console.ReadLine().ToUpper();
                tebakanPemain.Add(Input);
                if (CekJawaban(kataMisteri,tebakanPemain))
                {
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b\b\b\b");
                    Console.WriteLine("Selamat anda benar!!");
                    Console.WriteLine($"Kata misteri kali ini adalah {kataMisteri}");
                    break;
                }
                else if (kataMisteri.Contains(Input))
                {
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b\b\b\b");
                    Console.WriteLine($"Benar! Huruf {Input} ada dalam kata ini");
                    Console.WriteLine("Silahkan tebak huruf selanjutnya...");
                    Console.WriteLine(CekHuruf(kataMisteri,tebakanPemain));
                }
                else
                {
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b\b\b\b");
                    Console.WriteLine($"Salah! Huruf {Input} tidak ada dalam kata ini");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan anda menjawab tersisa {kesempatan} kesempatan");
                }
            }
        }

        static bool CekJawaban(string KataRahasia, List<string> list)
        {
            bool status = false;
            for (int i = 0; i < KataRahasia.Length; i++)
            {
                string c = Convert.ToString(KataRahasia[i]);
                if (list.Contains(c))
                {
                    status = true;
                }
                else
                {
                    return status = false;
                }
            }
            return status;
        }

        static string CekHuruf(string KataRahasia, List<string> list)
        {
            string x = "";

            for (int i = 0; i < KataRahasia.Length; i++)
            {
                string c = Convert.ToString(KataRahasia[i]);
                if (list.Contains(c))
                {
                    x = x + c;
                }
                else
                {
                    x = x + "_";
                }
            }
            return x;
        }

        static void showEnd()
        {
            Console.WriteLine("\n\n___________________________________________________________________________________\n");
            Console.WriteLine("Permainan telah berakhir");
            Console.WriteLine($"Kata misteri yang dimaksud adalah {kataMisteri}");
            Console.WriteLine("Tekan tombol apapun untuk keluar...");
            Console.WriteLine("___________________________________________________________________________________");
            Console.ReadKey();
            Console.Clear();
        }
    }
}        