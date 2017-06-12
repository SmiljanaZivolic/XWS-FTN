using Common;
using Common.ServiceContract;
using Common.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BankaUI
{
	public class MainWindowViewModel : ViewModelBase
	{
		private string banka = string.Empty;
		private RelayCommand clearingCommand;

		public MainWindowViewModel()
		{

		}


		public RelayCommand ClearingCommand
		{
			get { return clearingCommand ?? (clearingCommand = new RelayCommand(param => ClearingCommandExecute(), param => ClearingCommandCanExecute())); }
		}

		private void ClearingCommandExecute()
		{
			ChannelFactory<IBank> factory = new ChannelFactory<IBank>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:9000/" + banka));
			IBank proxy = factory.CreateChannel();

			try
			{
				proxy.DoClearing();
			}
			catch (Exception e)
			{ }
		}

		public bool ClearingCommandCanExecute()
		{
			return banka != string.Empty;
		}

		public string Banka
		{
			get { return banka; }
			set
			{
				banka = value;
				OnPropertyChanged("Banka");
			}
		}
	}
}
