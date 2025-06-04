using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace PrakSister6_22SA11A116
{
    public class DataRepository
    {
        private string filePath = HttpContext.Current.Server.MapPath("~/App_Data/Data.xml");

        public List<DataModel> GetAllData()
        {
            XDocument doc = XDocument.Load(filePath);
            return doc.Descendants("Data")
                      .Select(d => new DataModel
                      {
                          IdBuku = (int)d.Element("IdBuku"),
                          JudulBuku = (string)d.Element("JudulBuku"),
                          Deskripsi = (string)d.Element("Deskripsi")
                      })
                      .ToList();
        }

        public void TambahData(DataModel data)
        {
            XDocument doc = XDocument.Load(filePath);
            int idBaru = doc.Descendants("Data").Max(d => (int)d.Element("IdBuku")) + 1;

            XElement dataBaru = new XElement("Data",
                new XElement("IdBuku", idBaru),
                new XElement("JudulBuku", data.JudulBuku),
                new XElement("Deskripsi", data.Deskripsi)
            );

            doc.Root.Add(dataBaru);
            doc.Save(filePath);
        }

        public void UbahData(DataModel data)
        {
            XDocument doc = XDocument.Load(filePath);
            XElement ex = doc.Descendants("Data")
                             .FirstOrDefault(d => (int)d.Element("IdBuku") == data.IdBuku);

            if (ex != null)
            {
                ex.SetElementValue("JudulBuku", data.JudulBuku);
                ex.SetElementValue("Deskripsi", data.Deskripsi);
                doc.Save(filePath);
            }
        }

        public void HapusData(int id)
        {
            XDocument doc = XDocument.Load(filePath);
            XElement ex = doc.Descendants("Data")
                             .FirstOrDefault(d => (int)d.Element("IdBuku") == id);

            if (ex != null)
            {
                ex.Remove();
                doc.Save(filePath);
            }
        }
    }
}
