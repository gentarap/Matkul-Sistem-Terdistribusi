using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using P5_4_22SA11A116.Service;

namespace P5_4_22SA11A116.Controllers
{
    public class ProdukMVCController : Controller
    {
        private readonly XMLProduk prodService = new XMLProduk();
        // menampilkan halaman produk
        public ActionResult Index()
        {
            var produk = prodService.TampilProduk();
            return View(produk);
        }
    }
}