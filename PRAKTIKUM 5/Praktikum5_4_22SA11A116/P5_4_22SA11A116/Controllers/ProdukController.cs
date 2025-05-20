using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using P5_4_22SA11A116.Models;
using P5_4_22SA11A116.Service;

namespace P5_4_22SA11A116.Controllers
{
    public class ProdukController : ApiController
    {
        private readonly XMLProduk produkService = new XMLProduk();

        /*mengambil semua produk*/
        public IEnumerable<Produk> GetProduks()
        {
            return produkService.TampilProduk();
        }

        /*menambah produk baru*/
        [HttpPost]
        public IHttpActionResult TambahProduk([FromBody] Produk produkBaru)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Data Tidak Valid");
            }

            produkService.TambahProduk(produkBaru);
            return Ok(produkBaru);
        }
    }
}
