using System;

namespace UTS3DendaPengembalianBuku
{
    class Program
    {
        static void Main(string []args)
        {
            int masaPinjam;
            int masaPinjam1;
            int masaPinjam2;
            int masaPinjam3;
            int jumlahDenda;
            int jumlahDenda1;
            int jumlahDenda2;
            Console.Write("Input jumlah hari peminjaman : ");
            masaPinjam = Convert.ToInt32(Console.ReadLine());

            masaPinjam1 = masaPinjam -5;
            jumlahDenda = 10000;

            masaPinjam2 = masaPinjam -10;
            jumlahDenda1= 20000;
            int denda1  = 50000;
            int denda2  = jumlahDenda1*masaPinjam2;
            denda2      = denda2 + denda1;

            masaPinjam3 = masaPinjam -30;
            jumlahDenda2= 30000;
            int Denda2  = 400000;
            int denda3  = jumlahDenda2*masaPinjam3;
            denda3      = denda3 + denda1 + Denda2;

            if(masaPinjam > 5 && masaPinjam <= 10)
            {
                Console.Write($"Total denda : Rp.{jumlahDenda*masaPinjam1}");
            }
            else if(masaPinjam > 10 && masaPinjam <=30)
            {
                Console.Write($"Total denda : Rp.{denda2}");
            }
            else if(masaPinjam <= 5)
            {
                Console.Write("Total denda : Rp.0");
            }
            else
            {
                Console.WriteLine("Keanggotaan anda telah dibatalkan");
                Console.Write($"Total denda : Rp.{denda3}");
            }
        }
    }
}
