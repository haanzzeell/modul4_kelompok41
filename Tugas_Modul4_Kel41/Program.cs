using System;

namespace Tugas_Modul4_Kel41
{
    class Program
    {
        static void keterangan(string nama, string nim)
        {
            Console.WriteLine("Nama: " + nama + " NIM " + nim);
        }
        static void keterangan2(int kelompok, int shift)
        {
            Console.WriteLine("Kelompok " + kelompok + " shift ke-" + shift);
        }

        static void Main(string[] args)
        {

            string a;
            int b;
            hae hr = new hae();

            do
            {
                Console.WriteLine("============================================");

                Console.WriteLine("Senin   = 1                              {#}");
                Console.WriteLine("Selasa  = 2                              {#}");
                Console.WriteLine("Rabu    = 3                              {#}");
                Console.WriteLine("Kamin   = 4                              {#}");
                Console.WriteLine("Jum'at  = 5                              {#}");
                Console.WriteLine("============================================");
                Console.Write("Pilih hari :");
                a = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("============================================");
                int.TryParse(a, out b);
                switch (b)
                {
                    case (1):
                        hr.senin();
                        break;
                    case (2):
                        hr.selasa();
                        break;
                    case (3):
                        hr.rabu();
                        break;
                    case (4):
                        hr.kamis();
                        break;
                    case (5):
                        hr.jumat();
                        break;
                    default:
                        Console.WriteLine("Inputan salah");
                        break;

                }
                Console.WriteLine("============================================");
                Console.WriteLine("");
                Console.WriteLine("Apakah Ingin melihat jadwal hari lain? (ya)");
                a = Console.ReadLine();
                Console.WriteLine("____________________________________________");
                Console.WriteLine("");


            }
            while (a == "y");
            keterangan("Gunawan Prasetya", "21120119120025");
            keterangan("Hana Adilah", "21120119120024");
            keterangan2(41, 2);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.ReadKey();
        }
    }
}