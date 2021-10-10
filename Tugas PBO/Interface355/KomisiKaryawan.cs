using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface355
{
    public class KomisiKaryawan : Karyawan
    {
        private decimal penjualanKotor;
        private decimal tingkatKomisi;

        public KomisiKaryawan(string Depan, string Belakang, string ssn, decimal penjualan, decimal tingkat)
            : base(Depan, Belakang, ssn)
        {
            PenjualanKotor = penjualan;
            TingkatKomisi = tingkat;
        }
        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                penjualanKotor = (value >= 0) ? value : 0;
            }
        }
        public decimal TingkatKomisi
        {
            get
            {
                return tingkatKomisi;
            }
            set
            {
                tingkatKomisi = (value > 0 && value < 1) ? value : 0;
            }
        }
        public override decimal Pendapatan()
        {
            return TingkatKomisi * PenjualanKotor;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", " Nama Karyawan\t", base.ToString(), " Penjualan Kotor", PenjualanKotor, " Tingkat Komisi\t", TingkatKomisi);
        }
    }
}
