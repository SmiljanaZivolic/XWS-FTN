using Common;
using Common.Model;
using Common.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
	public class IzvodiViewModel : ViewModelBase
	{
		private List<Izvod> izvodi = new List<Izvod>();

		public IzvodiViewModel(string imeFirme)
		{
			Racun racun = DAO.GetRacunImeFirme(imeFirme);

			izvodi = DAO.GetIzvod(racun.BrojRacun);
		}

		public List<Izvod> Izvodi
		{
			get { return izvodi; }
			set { izvodi = value; OnPropertyChanged("Izvodi"); }
		}
	}
}
