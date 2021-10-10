using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface355
{
    public class KaryawanPerjam : Karyawan
    {
        private decimal upah;
        private decimal jam;

        public KaryawanPerjam(string Depan, string Belakang, string ssn, decimal upahPerjam, decimal jamKerja)
            : base(Depan, Belakang, ssn)
        {
            Upah = upahPerjam;
            Jam = jamKerja;
        }
        public decimal Upah
        {
            get
            {
                return upah;
            }
            set
            {
                upah = (value >= 0) ? value : 0;
            }
        }
        public decimal Jam
        {
            get
            {
                return jam;
            }
            set
            {
                jam = ((value >= 0) && (value <= 168)) ? value : 0;
            }
        }
        public override decimal Pendapatan()
        {
            if (Jam <= 40)
                return Upah * Jam;
            else
                return (40 * Upah) + ((Jam - 40) * 1.5M);
        }
        public override string ToString()
        {
            return string.Format(" Nama Karyawan\t: {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(), " Upah/jam\t", Upah, "\n Jam Kerja\t", Jam);
        }
    }
}
