using Common.UI;
using Firma.View;
using Firma.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
	public class MainWindowViewModel : ViewModelBase
	{
		private string imeFirme = string.Empty;
		private RelayCommand fakturaCommand;
		private RelayCommand izvodCommand;

		public MainWindowViewModel()
		{

		}

		public RelayCommand FakturaCommand
		{
			get { return fakturaCommand ?? (fakturaCommand = new RelayCommand(param => FakturaCommandExecute(), param => FakturaCommandCanExecute())); }
		}

		public RelayCommand IzvodCommand
		{
			get { return izvodCommand ?? (izvodCommand = new RelayCommand(param => IzvodCommandExecute(), param => IzvodCommandCanExecute())); }
		}

		public string ImeFirme
		{
			get { return imeFirme; }
			set 
			{
				imeFirme = value;
				OnPropertyChanged("ImeFirme");
			}
		}

		private void FakturaCommandExecute()
		{
			FaktureView view = new FaktureView();
			FaktureViewModel viewModel = new FaktureViewModel(ImeFirme);

			view.DataContext = viewModel;
			view.ShowDialog();
		}

		private bool FakturaCommandCanExecute()
		{
			return true;
		}

		private void IzvodCommandExecute()
		{
			IzvodView view = new IzvodView();
			IzvodiViewModel viewModel = new IzvodiViewModel(ImeFirme);

			view.DataContext = viewModel;
			view.ShowDialog();
		}

		private bool IzvodCommandCanExecute()
		{
			return true;
		}
	}
}
