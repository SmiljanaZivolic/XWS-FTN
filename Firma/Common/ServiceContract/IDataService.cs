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
	public interface IDataService
	{
		[OperationContract]
		List<Faktura> GetFakture();
	}
}
