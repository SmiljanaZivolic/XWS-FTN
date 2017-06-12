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
	public interface ICentralnaBanka
	{
		[OperationContract]
		MT900 RTGS(MT103 mt103);

		[OperationContract]
		void Clearing(List<MT102> mt102s);
	}
}
