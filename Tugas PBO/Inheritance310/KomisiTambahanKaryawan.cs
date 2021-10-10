using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter11hal310
{
    class KomisiTambahanKaryawan
    {
        public string NamaDepan;
        public string NamaBelakang;
        public string NomorKTP;
        private decimal penjualanKotor; // penjualan mingguan kotor
        private decimal tingkatKomisi; // persentase komisi
        private decimal gajiPokok; // gaji pokok per minggu

        // konstruktor enam parameter
        public KomisiTambahanKaryawan(string namaDepan, string namaBelakang, string nomorKTP, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok)
        {
            // panggilan implisit ke konstruktor objek terjadi di sini
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NomorKTP = nomorKTP;
            PenjualanKotor = penjualanKotor; // memvalidasi penjualan kotor
            TingkatKomisi = tingkatKomisi; // memvalidasi tingkat komisi
            GajiPokok = gajiPokok; // memvalidasi gaji pokok
        }
        public void setNamaDepan(string namaDepan)
        {
            NamaDepan = namaDepan;
        }
        public string getNamaDepan()
        {
            return NamaDepan;
        }
        public void setNamaBelakang(string namaBelakang)
        {
            NamaBelakang = namaBelakang;
        }
        public string getNamaBelakang()
        {
            return NamaBelakang;
        }
        public void setNomorKTP(string nomorKTP)
        {
            NomorKTP = nomorKTP;
        }
        public string getNomorKTP()
        {
            return NomorKTP;
        }
        // properti yang mendapatkan dan menetapkan komisi penjualan kotor karyawan
        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                penjualanKotor = (value < 0) ? 0 : value; // memvalidasi
            }
        }
        // properti yang mendapatkan dan menetapkan tingkat komisi komisi karyawan
        public decimal TingkatKomisi
        {
            get
            {
                return tingkatKomisi;
            }
            set
            {
                tingkatKomisi = (value > 0 && value < 1) ? value : 0; // memvalidasi
            }
        }
        // properti yang mendapatkan dan menetapkan KomisiTambahanKaryawan gaji pokok
        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                gajiPokok = (value < 0) ? 0 : value; // memvalidasi
            }
        }
        // menghitung komisi gaji pegawai
        public decimal Pendapatan()
        {
            return gajiPokok + (tingkatKomisi * penjualanKotor);
        }
        // mengembalikan representasi string dari objek KomisiKaryawan
        public override string ToString()
        {
            return string.Format(" Nama Depan\t: {0} \n Nama Belakang\t: {1} \n Nomor KTP\t: {2} \n Penjualan Kotor: {3} \n Tingkat Komisi : {4} \n Gaji Pokok\t: {5}", NamaDepan, NamaBelakang, NomorKTP, penjualanKotor, tingkatKomisi, gajiPokok);
        }
    }
}
