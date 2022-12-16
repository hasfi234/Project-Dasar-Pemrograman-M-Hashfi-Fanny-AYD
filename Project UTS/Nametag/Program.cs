using System;

namespace UTS1
{
   class Nametag
   {
    static void Main (string [] args)
    {
        Console.WriteLine("Nama : ");
        string nama = Console.ReadLine();
        Console.WriteLine("Nim : ");
        string nim = Console.ReadLine();
        Console.WriteLine("Konsentrasi : ");
        string konsentrasi  = Console.ReadLine();
        Console.WriteLine("|**********************|");
        Console.WriteLine("|Nama: {0,16}|", nama);
        Console.WriteLine("|      {0,16}|", nim);
        Console.WriteLine("|----------------------|");
        Console.WriteLine("|      {0,16}|",konsentrasi);
        Console.WriteLine("|**********************|");
        Console.ReadLine();
    }
   }
}