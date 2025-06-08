using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfCalculator_22SA11A116
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface ICalculator
	{
		[OperationContract]
		int tambah(int a, int b);

		[OperationContract]
		double bagi(double a, double b);

		[OperationContract]
		int kali(int a, int b);

		[OperationContract]
        int kurang(int a, int b);
    }
}
