using System;

namespace UTS2TebakAngka
{
    class program
    {
        
        static void Main(string []args)
        {
           int angka = 70;
           bool diTebak = false;
           while(!diTebak)
           {
              Console.Write("Tebak angka antara 1-100 : ");
              int angkaTebakan = Convert.ToInt32(Console.ReadLine());
              if(angkaTebakan==angka)
              {
                Console.WriteLine("Anda benar!");
                Console.WriteLine("Bye...");
                break;
              }
              else if(angkaTebakan<angka)
              {
                Console.WriteLine("Salah. Nilai teerlalu rendah.");
              }
              else if(angkaTebakan>angka)
              {
                Console.WriteLine("Salah. Nilai terlalu tinggi.");
              }
           }
        }

    }
}
