using Common.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace CentralnaBanka
{
	class Program
	{
		static void Main(string[] args)
		{
			NetTcpBinding binding = new NetTcpBinding();
			ServiceHost host = new ServiceHost(typeof(CentralnaBankaServer), new Uri("net.tcp://localhost:9001/CB"));
			host.AddServiceEndpoint(typeof(ICentralnaBanka), binding, "");
			host.Open();

			Console.Read();

		}
	}
}
