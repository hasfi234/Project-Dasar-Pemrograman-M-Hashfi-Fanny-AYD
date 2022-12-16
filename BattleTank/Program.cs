using System;

namespace BattleTank
{
    class program
    {
        static void Main(string[]args)
        {
            //inisialisasi variabel
            int panjangArea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahTank = 3;

            char[,] playArea = buatRuang(panjangArea,rumput,tank,jumlahTank);

            printArea(playArea,rumput,tank);

            int jumlahTanktersembunyi = jumlahTank;

            //Gameplay
            while(jumlahTanktersembunyi >0)
            {
                int[] tebakanKoordinat = getKoordinatTebakan(panjangArea);
                char updateTampilanArea = verifikasiTebakan(tebakanKoordinat, playArea, tank, rumput, hit, miss);
                if(updateTampilanArea == hit){
                    jumlahTanktersembunyi--;
                }
                playArea = updateArea(playArea, tebakanKoordinat, updateTampilanArea);
                printArea(playArea,rumput,tank);

            }

            Console.WriteLine("Game Over");
            Console.Read();
            Console.Clear();
        }

        //membuat area permainan
        static char [,] buatRuang(int panjangArea, char rumput, char tank, int jumlahTank)
        {
            char[,] ruangan = new char [panjangArea,panjangArea];

            for(int baris = 0; baris < panjangArea; baris++)
            {
                for(int kolom = 0; kolom < panjangArea; kolom++)
                {
                    ruangan[baris,kolom] = rumput;
                }
            }
            return letakkanTank(ruangan,jumlahTank,rumput,tank);
        }

        static char[,] letakkanTank(char[,] ruang, int jumlahTank, char rumput, char tank)
        {
            int letakTank = 0;
            int panjangArea = 5;

            while(letakTank<jumlahTank)
            {
                int[] lokasiTank = tentukanKoordinatTank(panjangArea);
                char posisi = ruang[lokasiTank[0],lokasiTank[1]];

                if(posisi==rumput)
                {
                    ruang[lokasiTank[0],lokasiTank[1]] = tank;
                    letakTank++;
                }
            }

            return ruang;
        }

        //menentukan posisi koordinat tank (x,y)
        static int[] tentukanKoordinatTank(int panjangArea)
        {
            Random rng = new Random();
            int[] koordinat = new int[2];
            for(int i = 0 ; i < koordinat.Length; i++)
            {
             koordinat[i] = rng.Next(panjangArea);
            }

            return koordinat;
        }

        static void printArea(char[,] playArea, char rumput, char tank)
        {
            Console.Write("  ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();

            for(int baris = 0; baris < 5; baris++)
            {
                Console.Write(baris + 1 + " ");
                for(int kolom = 0; kolom < 5; kolom++)
                {
                  char posisi = playArea[baris,kolom];
                  if(posisi == tank)
                  {
                    Console.Write(rumput + " ");
                  }else{
                    Console.Write(posisi + " ");
                  }
                }
                Console.WriteLine();
            }

        }

        static int[] getKoordinatTebakan(int panjangArea)
        {
            int baris;
            int kolom;

            do{
                Console.Write("Pilih Baris : ");
                baris = Convert.ToInt32(Console.ReadLine());
            }while(baris<0 || baris>panjangArea + 1);

            do{
                Console.Write("Pilih Kolom : ");
                kolom = Convert.ToInt32(Console.ReadLine());
            }while(kolom<0 || kolom>panjangArea +1);

            return new[]{baris-1,kolom-1};
        }

        static char verifikasiTebakan(int[] tebakan, char[,] playArea, char tank, char rumput, char hit, char miss)
        {
            string pesan;
            int baris = tebakan[0];
            int kolom = tebakan[1];
            char target = playArea[baris, kolom];
            
            if(target == tank)
            {
                pesan = "TEMBAKAN ANDA TEPAT SASARAN, TANK MELEDAK!!!";
                target = hit;
            }
            else if(target == rumput)
            {
                pesan = "SAYANG SEKALI, TEMBAKAN ANDA MELESET!!!";
                target = miss;
            }
            else
            {
                pesan = "AREA INI AMAN!!!";
            }

            Console.WriteLine(pesan);
            Console.WriteLine(" ");
            return target;
        }

        static char[,] updateArea(char[,] ruang, int[] tebakan, char updateTampilanArea)
        {
            int baris = tebakan[0];
            int kolom = tebakan[1];
            ruang[baris,kolom] = updateTampilanArea;
            return ruang;
        }

    }
} 
