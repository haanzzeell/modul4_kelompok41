using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Modul4_Kel41
{
    class hae
    {
        public void senin()
        {
            String[] x = { "1. Sistem digital pada pukul 08.50-10.30", "2. Praktikum DKP pada pukul 18.00-18.50", "3. Konsep Jaringan Komputer pada pukul 20.00-21.40" };

            foreach (String y in x)
            {
                Console.WriteLine(y);
            }
        }
        public void selasa()
        {
            String[] x = { "1. Algoritma dan Pemprogaman pada pukul 08.50-10.30", "2. Fisika dasar 2 pada pukul 12.30-14.10" };

            foreach (String y in x)
            {
                Console.WriteLine(y);
            }
        }
        public void rabu()
        {
            String[] x = { "1. Kalkulus 2 pada pukul 12.40-15.10", "2. Kecakapan Antar Personal pada pukul 15.10-16.50" };

            foreach (String y in x)
            {
                Console.WriteLine(y);
            }
        }
        public void kamis()
        {
            String[] x = { "1. Kewarganegaraan pada pukul 08.20-10.00", "2. Metode Penelitian pada pukul 12.30-14.10" };
            Console.WriteLine("Mata kuliah :");
            foreach (String y in x)
            {
                Console.WriteLine(y);
            }
        }
        public void jumat()
        {
            String[] x = { "1. Etika Profesi pada jam 07.00-08,40", "2. Elektonika dasar pada jam 14.00-16.30", "3. Praktimu Fisika dasar pada pukul 18.00-18.50" };
            Console.WriteLine("Mata kuliah :");
            foreach (String y in x)
            {
                Console.WriteLine(y);
            }
        }
    }

}