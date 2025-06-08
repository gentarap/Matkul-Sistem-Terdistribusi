using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfDbase_22SA11A116.Entity;

namespace WcfDbase_22SA11A116
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IEmployee
    {
        DataSet ds;

        public List<Pegawai> getPegawaiList()
        {
            string query = "select a.nip, a.nama, a.jenis_kelamin, a.alamat, b.nama_jabatan " +
                           "from pegawai a, jabatan b " +
                           "where a.kode_jabatan = b.kode_jabatan";

            ds = Fungsi.dataGrid(query, "pegawai");

            List<Pegawai> list = new List<Pegawai>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Pegawai p = new Pegawai();
                p.NIP = item["nip"].ToString();
                p.NAMA = item["nama"].ToString();
                p.JENIS_KELAMIN = item["jenis_kelamin"].ToString();
                p.ALAMAT = item["alamat"].ToString();
                p.NAMA_JABATAN = item["nama_jabatan"].ToString();
                list.Add(p);
            }

            return list;
        }

        public List<Pegawai> getPegawaiByName(string name)
        {
            string query = "select a.nip, a.nama, a.jenis_kelamin, a.alamat, b.nama_jabatan " +
                           "from pegawai a, jabatan b " +
                           "where a.kode_jabatan = b.kode_jabatan " +
                           "and a.nama like '%" + name + "%'";

            ds = Fungsi.dataGrid(query, "pegawai");

            List<Pegawai> list = new List<Pegawai>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Pegawai p = new Pegawai();
                p.NIP = item["nip"].ToString();
                p.NAMA = item["nama"].ToString();
                p.JENIS_KELAMIN = item["jenis_kelamin"].ToString();
                p.ALAMAT = item["alamat"].ToString();
                p.NAMA_JABATAN = item["nama_jabatan"].ToString();
                list.Add(p);
            }

            return list;
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }
    }
}
