using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp_22SA11A116.Models
{
    //22SA11A116
    public class PegawaiModel : IPegawaiRepository
    {
        kepegawaianEntities context = new kepegawaianEntities();

        public IEnumerable<pegawai> GetAll()
        {
            return context.pegawais;
        }

        public pegawai GetById(string nip)
        {
            IQueryable<pegawai> emp = context.pegawais.Where(a => a.nip == nip);
            return emp.FirstOrDefault();
        }

        public int Update(pegawai emp)
        {
            pegawai updatePegawai = context.pegawais.FirstOrDefault(n => n.nip == emp.nip);
            updatePegawai.nama = emp.nama.Trim();
            updatePegawai.jenis_kelamin = emp.jenis_kelamin.Trim();
            updatePegawai.alamat = emp.alamat.Trim();
            updatePegawai.kode_jabatan = emp.kode_jabatan;

            return context.SaveChanges();
        }

        public pegawai Add(pegawai emp)
        {
            var addedPegawai = context.pegawais.Add(emp);
            context.SaveChanges();

            return addedPegawai;
        }

        public void Delete(string nip)
        {
            pegawai d = context.pegawais.FirstOrDefault(a => a.nip == nip);
            context.pegawais.Remove(d);
            context.SaveChanges();
        }
    }
}
