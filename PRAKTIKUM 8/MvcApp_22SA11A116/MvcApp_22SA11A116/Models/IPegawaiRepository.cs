using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApp_22SA11A116.Models
{
    //22SA11A116
    interface IPegawaiRepository
    {
        IEnumerable<pegawai> GetAll();
        pegawai GetById(string nip);
        int Update(pegawai emp);
        pegawai Add(pegawai emp);
        void Delete(string nip);
    }
}

