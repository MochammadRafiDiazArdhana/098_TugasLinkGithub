using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface355
{
    public abstract class Karyawan
    {
        private string NamaDepan;
        private string NamaBelakang;
        private string SSN;
        public Karyawan(string Depan, string Belakang, string ssn)
        {
            NamaDepan = Depan;
            NamaBelakang = Belakang;
            SSN = ssn;
        }
        public string namaDepan
        {
            get
            {
                return NamaDepan;
            }
        }
        public string namaBelakang
        {
            get
            {
                return NamaBelakang;
            }
        }
        public string Ssn
        {
            get
            {
                return SSN;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}\n Nomor KTP\t: {2}", namaDepan, namaBelakang, Ssn);
        }
        public abstract decimal Pendapatan();
    }
}
