using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common.ServiceContract
{
	[ServiceContract]
	public interface IBank
	{
		[OperationContract]
		void SendNalogPrenos(NalogPrenos prenos);

		[OperationContract]
		void ObradiRTGS(MT103 mt103, MT910 mt910);

		[OperationContract]
		void ObradiClearing(MT102Stavka mt102, MT910 mt910);

		[OperationContract]
		void DoClearing();
	}
}
