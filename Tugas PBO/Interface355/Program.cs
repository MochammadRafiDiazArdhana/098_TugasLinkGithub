using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface355
{
    class Program
    {
        static void Main(string[] args)
        {
            GajiKaryawan gajiKaryawan = new GajiKaryawan("John", "Smith", "111-11-1111", 800.00M);
            KaryawanPerjam karyawanPerjam = new KaryawanPerjam("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            KomisiKaryawan komisiKaryawan = new KomisiKaryawan("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            KomisiTambahanKaryawan komisiTambahanKaryawan = new KomisiTambahanKaryawan("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("================================================");
            Console.WriteLine("   ------------------------------------------");
            Console.WriteLine("      Karyawan diproses secara Individual");
            Console.WriteLine("   ------------------------------------------");
            Console.WriteLine("================================================\n");
            Console.WriteLine("{0}\n{1}: {2:C}\n", gajiKaryawan, " Diperoleh\t", gajiKaryawan.Pendapatan());
            Console.WriteLine("================================================\n");
            Console.WriteLine("{0}\n{1}: {2:C}\n", karyawanPerjam, " Diperoleh\t", karyawanPerjam.Pendapatan());
            Console.WriteLine("================================================\n");
            Console.WriteLine("{0}\n{1}: {2:C}\n", komisiKaryawan, " Diperoleh\t", komisiKaryawan.Pendapatan());
            Console.WriteLine("================================================\n");
            Console.WriteLine("{0}\n{1}: {2:C}\n", komisiTambahanKaryawan, " Diperoleh\t", komisiTambahanKaryawan.Pendapatan());
            Console.WriteLine("================================================");

            Karyawan[] karyawan = new Karyawan[4];

            karyawan[0] = gajiKaryawan;
            karyawan[1] = karyawanPerjam;
            karyawan[2] = komisiKaryawan;
            karyawan[3] = komisiTambahanKaryawan;

            Console.WriteLine("   ------------------------------------------");
            Console.WriteLine("    Karyawan diproses secara Polymorphically");
            Console.WriteLine("   ------------------------------------------");

            foreach (Karyawan karyawanSekarang in karyawan)
            {
                Console.WriteLine("================================================\n");
                Console.WriteLine(karyawanSekarang);
                if (karyawanSekarang is KomisiTambahanKaryawan)
                {
                    KomisiTambahanKaryawan pegawai = (KomisiTambahanKaryawan)karyawanSekarang;

                    pegawai.GajiPokok *= 1.10M;
                    Console.WriteLine(" kenaikan 10%\t: {0:C}", pegawai.GajiPokok);
                }
                Console.WriteLine(" Diperoleh\t: {0:C}\n", karyawanSekarang.Pendapatan());
            }
            Console.WriteLine("================================================\n");
            for (int j = 0; j < karyawan.Length; j++)
                Console.WriteLine(" Pegawai {0} adalah {1}", j, karyawan[j].GetType());
            Console.ReadLine();
        }
    }
}
