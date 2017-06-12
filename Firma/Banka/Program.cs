using Common.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
	class Program
	{
		static void Main(string[] args)
		{
			NetTcpBinding bindingBankaA = new NetTcpBinding();
			ServiceHost hostBankaA = new ServiceHost(typeof(BankaServer), new Uri("net.tcp://localhost:9000/bankaA"));
			hostBankaA.AddServiceEndpoint(typeof(IBank), bindingBankaA, "");
			hostBankaA.Open();

			NetTcpBinding bindingBankaB = new NetTcpBinding();
			ServiceHost hostBankaB = new ServiceHost(typeof(BankaServer), new Uri("net.tcp://localhost:9000/bankaB"));
			hostBankaB.AddServiceEndpoint(typeof(IBank), bindingBankaB, "");
			hostBankaB.Open();

			Console.Read();
		}
	}
}
