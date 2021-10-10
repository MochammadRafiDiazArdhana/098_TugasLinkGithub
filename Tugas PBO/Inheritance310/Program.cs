using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter11hal310
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat instance objek KomisiKaryawan
            KomisiTambahanKaryawan karyawan = new KomisiTambahanKaryawan("Bob", "Lewis", "333-33-333", 5000.00M, .04M, 300.00M);
            // menampilkan data KomisiKaryawan
            Console.WriteLine("=============================================");
            Console.WriteLine("             Informasi karyawan ");
            Console.WriteLine("=============================================\n");
            Console.WriteLine(" Nama Depan adalah {0}", karyawan.NamaDepan);
            Console.WriteLine(" Nama Belakang adalah {0}", karyawan.NamaBelakang);
            Console.WriteLine(" Nomor KTP adalah {0}", karyawan.NomorKTP);
            Console.WriteLine(" Penjualan Kotornya adalah {0:C}", karyawan.PenjualanKotor);
            Console.WriteLine(" Tingkat Komisinya adalah {0:F2}", karyawan.TingkatKomisi);
            Console.WriteLine(" Gaji Pokoknya adalah {0:C}", karyawan.GajiPokok);
            Console.WriteLine(" Pendapatanya adalah {0:C}", karyawan.Pendapatan());

            karyawan.PenjualanKotor = 5000.00M; // menetapkan penjualan kotor
            karyawan.TingkatKomisi = .04M; // menetapkan tingkat  komisi
            karyawan.GajiPokok = 1000.00M; // menetapkan gaji pokok

            Console.WriteLine("\n=============================================");
            Console.WriteLine("         Pembaruan Informasi Karyawan");
            Console.WriteLine("=============================================");
            Console.WriteLine("\n{0}", karyawan);
            Console.WriteLine(" Pendapatan\t: {0:C}", karyawan.Pendapatan());
            Console.ReadLine();
        }
    }
}
