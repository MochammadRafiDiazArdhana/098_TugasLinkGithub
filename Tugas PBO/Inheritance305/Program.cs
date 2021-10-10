using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance305
{
    class Program
    {
        static void Main(string[] args)
        {
            KomisiKaryawan karyawan = new KomisiKaryawan("Sue", "Jones", "222-22-222", 10000.00M, .06M);
            // menampilkan data KomisiKaryawan
            Console.WriteLine("=============================================");
            Console.WriteLine("             Informasi karyawan ");
            Console.WriteLine("=============================================\n");
            Console.WriteLine(" Nama Depan adalah {0}", karyawan.NamaDepan);
            Console.WriteLine(" Nama Belakang adalah {0}", karyawan.NamaBelakang);
            Console.WriteLine(" Nomer KTPr adalah {0}", karyawan.NomerKTP);
            Console.WriteLine(" Penjualan Kotornya adalah {0:C}", karyawan.PenjualanKotor);
            Console.WriteLine(" Tingkat Komisinya adalah {0:F2}", karyawan.TingkatKomisi);
            Console.WriteLine(" Pendapatanya adalah {0:C}", karyawan.Pendapatan());

            karyawan.PenjualanKotor = 5000.00M; // menetapkan penjualan kotor
            karyawan.TingkatKomisi = .1M; // menetapkan tingkat  komisi

            Console.WriteLine("\n=============================================");
            Console.WriteLine("         Pembaruan Informasi Karyawan");
            Console.WriteLine("=============================================");
            Console.WriteLine("\n{0}", karyawan);
            Console.WriteLine(" Pendapatan\t: {0:C}", karyawan.Pendapatan());
            Console.ReadLine();
        }
    }
}
