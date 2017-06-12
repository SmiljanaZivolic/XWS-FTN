using Common.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
	public class Izvod : ViewModelBase
	{
		private int izvodId;
		private string svrhaPlacanja;
		private string duznik;
		private string primalac;
		private DateTime datumNaloga;
		private DateTime datumValute;
		private string racunDuznika;
		private int modelZaduzenja;
		private string pozivNaBrojZaduzenja;
		private string racunPoverioca;
		private int modelOdobrenja;
		private string pozivNaBrojOdobrenja;
		private double iznos;

		public Izvod(string svrhaPlacanja, 
			string duznik, string primalac,
			DateTime datumNaloga, DateTime datumValute, string racunDuznika, int modelZaduzenja, string pozivNaBrojZaduzenja, string racunPoverioca, int modelOdobrenja, string pozivNaBrojOdobrenja, double iznos)
		{
			this.izvodId = izvodId;
			this.svrhaPlacanja = svrhaPlacanja;
			this.duznik = duznik;
			this.primalac = primalac;
			this.datumNaloga = datumNaloga;
			this.datumValute = datumValute;
			this.racunDuznika = racunDuznika;
			this.modelZaduzenja = modelZaduzenja;
			this.pozivNaBrojZaduzenja = pozivNaBrojZaduzenja;
			this.racunPoverioca = racunPoverioca;
			this.modelOdobrenja = modelOdobrenja;
			this.pozivNaBrojOdobrenja = pozivNaBrojOdobrenja;
			this.iznos = iznos;
		}

		public DateTime DatumNaloga
		{
			get { return datumNaloga; }
			set { datumNaloga = value; OnPropertyChanged("DatumNaloga"); }
		}

		public double Iznos
		{
			get { return iznos; }
			set { iznos = value; OnPropertyChanged("Iznos"); }
		}

		public string PozivNaBrojOdobrenja
		{
			get { return pozivNaBrojOdobrenja; }
			set { pozivNaBrojOdobrenja = value; OnPropertyChanged("PozivNaBrojOdobrenja"); }
		}

		public int ModelOdobrenja
		{
			get { return modelOdobrenja; }
			set { modelOdobrenja = value; OnPropertyChanged("ModelOdobrenja"); }
		}

		public string RacunPoverioca
		{
			get { return racunPoverioca; }
			set { racunPoverioca = value; OnPropertyChanged("RacunPoverioca"); }
		}

		public string PozivNaBrojZaduzenja
		{
			get { return pozivNaBrojZaduzenja; }
			set { pozivNaBrojZaduzenja = value; OnPropertyChanged("PozivNaBrojZaduzenja"); }
		}

		public int ModelZaduzenja
		{
			get { return modelZaduzenja; }
			set { modelZaduzenja = value; OnPropertyChanged("ModelZaduzenja"); }
		}

		public string RacunDuznika
		{
			get { return racunDuznika; }
			set { racunDuznika = value; OnPropertyChanged("RacunDuznika"); }
		}

		public DateTime DatumValute
		{
			get { return datumValute; }
			set { datumValute = value; OnPropertyChanged("DatumValute"); }
		}

		public string Primalac
		{
			get { return primalac; }
			set { primalac = value; OnPropertyChanged("Primalac"); }
		}

		public string Duznik
		{
			get { return duznik; }
			set { duznik = value; OnPropertyChanged("Duznik"); }
		}

		public int IzvodId
		{
			get { return izvodId; }
			set { izvodId = value; OnPropertyChanged("IzvodId"); }
		}

		public string SvrhaPlacanja
		{
			get { return svrhaPlacanja; }
			set { svrhaPlacanja = value; OnPropertyChanged("SvrhaPlacanja"); }
		}
	}
}
