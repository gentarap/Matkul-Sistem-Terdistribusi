using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfCalculator_22SA11A116
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ICalculator
    {
        public int tambah(int a, int b)
        {
            return a + b;
        }
        public double bagi(double a, double b)
        {
            return a / b;
        }
        public int kali(int a, int b)
        {
            return a * b;
        }
        public int kurang(int a, int b)
        {
            return a - b;
        }
    }
}
