using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance305
{
    class KomisiKaryawan
    {
        public string NamaDepan;
        public string NamaBelakang;
        public string NomerKTP; 
        private decimal penjualanKotor;
        private decimal tingkatKomisi;

        // konstruktor lima parameter
        public KomisiKaryawan(string namaDepan, string namaBelakang,string nomerKTP, decimal penjualanKotor, decimal tingkatKomisi)
        {
            // panggilan implisit ke konstruktor objek terjadi di sini
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NomerKTP = nomerKTP;
            PenjualanKotor = penjualanKotor; // memvalidasi penjualan kotor
            TingkatKomisi = tingkatKomisi; // memvalidasi tingkat komisi
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
        public void setSocialSecurityNumber(string socialSecurityNumber)
        {
            NomerKTP = socialSecurityNumber;
        }
        public string getSocialSecurityNumber()
        {
            return NomerKTP;
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
        // menghitung komisi gaji pegawai
        public decimal Pendapatan()
        {
            return tingkatKomisi * penjualanKotor;
        }
        // mengembalikan representasi string dari objek KomisiKaryawan
        public override string ToString()
        {
            return string.Format(" Nama Depan\t: {0} \n Nama Belakang\t: {1} \n Nomer KTP\t: {2} \n Penjualan Kotor: {3} \n Tingkat Komisi : {4}", NamaDepan, NamaBelakang, NomerKTP, penjualanKotor, tingkatKomisi);
        }
        public class KomisiTambahanKaryawan : KomisiKaryawan
        {
            private decimal gajiPokok;

            public KomisiTambahanKaryawan(string namaDepan, string namaBelakang, string socialSecurityNumber, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok)
                : base(namaDepan, namaBelakang, socialSecurityNumber, penjualanKotor, tingkatKomisi)
            {
                GajiPokok = gajiPokok;
            }
            public decimal GajiPokok
            {
                get
                {
                    return gajiPokok;
                }
                set
                {
                    gajiPokok = (value < 0) ? 0 : value;
                }
            }
            public decimal Pendapatan()
            {
                return tingkatKomisi * penjualanKotor;
            }
        }
    }
}
