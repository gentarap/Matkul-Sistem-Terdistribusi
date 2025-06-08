using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfDbase_22SA11A116.Entity
{
    public class Pegawai
    {
        private string nip;
        private string nama;
        private string jenis_kelamin;
        private string alamat;
        private string nama_jabatan;

        public string NIP
        {
            get { return nip; }
            set { nip = value; }
        }

        public string NAMA
        {
            get { return nama; }
            set { nama = value; }
        }

        public string JENIS_KELAMIN
        {
            get { return jenis_kelamin; }
            set { jenis_kelamin = value; }
        }

        public string ALAMAT
        {
            get { return alamat; }
            set { alamat = value; }
        }

        public string NAMA_JABATAN
        {
            get { return nama_jabatan; }
            set { nama_jabatan = value; }
        }
    }
}
