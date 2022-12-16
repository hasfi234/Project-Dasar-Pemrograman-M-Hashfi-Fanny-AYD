//Nama : M Hashfi Fanny AYD
//NIM : 2207112576
//Kelas : TI-A

using System;

namespace AduDadu
{
    class Program
    {
        static int DaduAnda;
        static int DaduKomputer;
        static int PointAnda;
        static int PointKomputer;
        static int Ronde = 1;
        static int PointSeri;
        static bool GameStart;

        static void Main(string[] args)
        {
            Console.Clear();

            GameStart = true;
            while (GameStart)
            {
                if (Ronde == 1)
                {
                    Intro();
                }
                else if (Ronde <= 10)
                {
                    PlayGame();
                    GameStart = (true);
                }
                else 
                {
                    ShowEnd(true);
                    GameStart = (false);
                }
            }
            Console.Write("\nTekan Enter untuk keluar...");
            Console.ReadKey();
            
        }

        static void Int()
        {
            Random rnp = new Random();
            DaduAnda = rnp.Next(1, 7);
            DaduKomputer = rnp.Next(1, 7);
        }

        static void Intro()
        {
            Console.WriteLine("========================)ADU DADU(============================");
            Console.WriteLine("\n==============================================================\n");
            Console.WriteLine("Pada game ini anda dan komputer akan bermain 10 ronde");
            Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Siapa yang akan menang? Selamat berjuang!");
            Console.WriteLine("\n==============================================================");
            Console.WriteLine("\nTekan tombol apa saja untuk memulai permainan...");
            Console.ReadKey();
            PlayGame();
        }

        static void PlayGame()
        {
            Int();
            Console.WriteLine("\n=========================)Ronde " + Ronde + "(============================");
            Console.WriteLine("Nilai Komputer : " + DaduKomputer);
            Console.WriteLine("Lempar dadu anda...");
            Console.ReadKey();
            Console.Write("...");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b\b\b\b");
            Console.WriteLine("Nilai Anda : " + DaduAnda);
            if (DaduAnda > DaduKomputer)
            { 
                PointAnda++;
                if (Ronde < 10)
                {
                 Console.WriteLine("Anda memenagkan ronde ini");
                 Console.WriteLine("Skor - Anda : " + PointAnda + ". Komputer : " + PointKomputer + ". Seri : " + PointSeri + ".");
                 Console.WriteLine("Lanjutkan ke ronde berikutnya...");
                 Console.ReadKey();
                }
                else if (Ronde == 10)
                {
                 Console.WriteLine("Anda memenagkan ronde ini");
                 Console.WriteLine("Skor - Anda : " + PointAnda + ". Komputer : " + PointKomputer + ". Seri : " + PointSeri + ".");
                 Console.WriteLine("Tekan tombol apapun untuk melihat skor akhir");
                 Console.ReadKey();
                }
                Ronde++;
            }
            else if (DaduAnda < DaduKomputer)
            {
                PointKomputer++;
                 if (Ronde < 10)
                 {
                     Console.WriteLine("Komputer memenagkan ronde ini");
                     Console.WriteLine("Skor - Anda : " + PointAnda + ". Komputer : " + PointKomputer + ". Seri : " + PointSeri + ".");
                     Console.WriteLine("Lanjutkan ke ronde berikutnya...");
                     Console.ReadKey();
                 }
                 if(Ronde == 10)
                 {
                     Console.WriteLine("Komputer memenagkan ronde ini");
                     Console.WriteLine("Skor - Anda : " + PointAnda + ". Komputer : " + PointKomputer + ". Seri : " + PointSeri + ".");
                     Console.WriteLine("Tekan tombol apapun untuk melihat skor akhir");
                     Console.ReadKey();
                 }
                Ronde++;
            }
            else
            {
                PointSeri++;
                if (Ronde < 10)
                {
                 Console.WriteLine("Ronde ini seri!");
                 Console.WriteLine("Skor - Anda : " + PointAnda + ". Komputer : " + PointKomputer + ". Seri : " + PointSeri + ".");
                 Console.WriteLine("Lanjutkan ke ronde berikutnya...");
                 Console.ReadKey();   
                }
                else if (Ronde == 10)
                {
                 Console.WriteLine("Ronde ini seri!");
                 Console.WriteLine("Skor - Anda : " + PointAnda + ". Komputer : " + PointKomputer + ". Seri : " + PointSeri + ".");
                 Console.WriteLine("Tekan tombol apapun untuk melihat skor akhir");
                 Console.ReadKey();   
                }
                Ronde++;
            }
        }

        static void ShowEnd(bool GameStart)
        {
            if (PointAnda > PointKomputer)
            {
                Console.WriteLine("\n==============================================================");
                Console.WriteLine("\nPermainan ini selesai");
                Console.WriteLine("Skor Akhir - Anda : " + PointAnda + ". Komputer : " + PointKomputer + ". Seri : " + PointSeri + ".");
                Console.WriteLine("Selamat, Anda menang!!");
            }
            else if (PointAnda < PointKomputer)
            {
                Console.WriteLine("\n==============================================================");
                Console.WriteLine("\nPermainan ini selesai");
                Console.WriteLine("Skor Akhir - Anda : " + PointAnda + ". Komputer : " + PointKomputer + ". Seri : " + PointSeri + ".");
                Console.WriteLine("Sayang sekali, Anda kalah!!");
            }
            else
            {
                Console.WriteLine("\n==============================================================");
                Console.WriteLine("\nPermainan ini selesai");
                Console.WriteLine("Skor Akhir - Anda : " + PointAnda + ". Komputer : " + PointKomputer + ". Seri : " + PointSeri + ".");
                Console.WriteLine("Permainan ini seri!!");
            }
        }
    }
}