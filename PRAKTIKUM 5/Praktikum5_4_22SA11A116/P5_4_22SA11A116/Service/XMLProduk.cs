using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using P5_4_22SA11A116.Models;
using System.IO;
using System.Web.Hosting;
using System.Xml.Serialization;

namespace P5_4_22SA11A116.Service
{
    public class XMLProduk
    {
        private readonly string xmlFilePath = HostingEnvironment.MapPath("~/App_data/produk.xml");
        public List<Produk> TampilProduk()
        {
            if (!File.Exists(xmlFilePath)) return new List<Produk>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Produk>));
            using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
            {
                return (List<Produk>)serializer.Deserialize(fs);
            }
        }

        public void TambahProduk(Produk pr)
        {
            var prod = TampilProduk();
            pr.Kode_produk = prod.Any() ? prod.Max(p => p.Kode_produk) + 1 : 1;
            prod.Add(pr);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Produk>));
            using (FileStream fs = new FileStream(xmlFilePath, FileMode.Create))
            {
                serializer.Serialize(fs, prod);
            }
        }
    }
}