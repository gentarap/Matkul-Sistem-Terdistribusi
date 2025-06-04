using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Praktikum6_1_22SA11A116
{
    /// <summary>
    /// Summary description for Airthmatic
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Airthmatic : System.Web.Services.WebService {

        //[WebMethod]
        //public string HelloWorld() {
        //    return "Hello World";
        //}

        [WebMethod]
        public int Add(int x, int y)
        {
            return x + y;
        }
        [WebMethod]
        public int Sub(int x, int y)
        {
            return x - y;
        }
        [WebMethod]
        public int Mul(int x, int y)
        {
            return x * y;
        }
        [WebMethod]
        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}
