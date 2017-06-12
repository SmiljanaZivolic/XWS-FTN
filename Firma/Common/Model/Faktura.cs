using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Common.UI;
using System.Runtime.Serialization;

namespace Common.Model
{
	[DataContract]
	public class Faktura : ViewModelBase
	{
		private int idFaktura;
		private string idPoruka;
		private string nazivDobavljaca;
		private string adresaDobavljaca;
		private string pibDobavljaca;
		private string nazivKupca;
		private string adresaKupca;
		private string pibKupca;
		private int brojRacuna;
		private DateTime datumRacuna;
		private double vrednostRobe;
		private double vrednostUsluge;
		private double ukupnoRobeIUsluga;
		private double ukupanRabat;
		private double ukupanPorez;
		private string oznakaValute;
		private double iznosZaUplatu;
		private string uplataNaRacun;
		private DateTime datumValute;

		private List<StavkaFakture> stavke = new List<StavkaFakture>();


		public Faktura()
		{

		}

		public Faktura(int idFaktura, string idPoruka, string nazivDobavljaca, string adresaDobavljaca, 
			string pibDobavljaca, string nazivKupca, string adresaKupca, string pibKupca, int brojRacuna, 
			double vrednostRobe, double vrednostUsluge, double ukupnoRobeIUsluga, double ukupanRabat,
			double ukupanPorez, string oznakaValute, double iznosZaUplatu, string uplataNaRacun, 
			DateTime datumValute, DateTime datumRacuna)
		{
			this.idFaktura = idFaktura;
			this.idPoruka = idPoruka;
			this.nazivDobavljaca = nazivDobavljaca;
			this.adresaDobavljaca = adresaDobavljaca;
			this.pibDobavljaca = pibDobavljaca;
			this.nazivKupca = nazivKupca;
			this.adresaKupca = adresaKupca;
			this.pibKupca = pibKupca;
			this.brojRacuna = brojRacuna;
			this.vrednostRobe = vrednostRobe;
			this.vrednostUsluge = vrednostUsluge;
			this.ukupnoRobeIUsluga = ukupnoRobeIUsluga;
			this.ukupanRabat = ukupanRabat;
			this.ukupanPorez = ukupanPorez;
			this.oznakaValute = oznakaValute;
			this.iznosZaUplatu = iznosZaUplatu;
			this.uplataNaRacun = uplataNaRacun;
			this.datumValute = datumValute;
			this.datumRacuna = datumRacuna;

		}

		[DataMember]
		public int IdFaktura
		{
			get { return idFaktura; }
			set
			{
				idFaktura = value;
				OnPropertyChanged("IdFaktura");
			}
		}

		[DataMember]
		public string IdPoruka
		{
			get { return idPoruka; }
			set
			{
				idPoruka = value;
				OnPropertyChanged("IdPoruka");
			}
		}

		[DataMember]
		public string NazivDobavljaca
		{
			get { return nazivDobavljaca; }
			set
			{
				nazivDobavljaca = value;
				OnPropertyChanged("NazivDobavljaca");
			}
		}

		[DataMember]
		public string AdresaDobavljaca
		{
			get { return adresaDobavljaca; }
			set
			{
				adresaDobavljaca = value;
				OnPropertyChanged("AdresaDobavljaca");
			}
		}
		
		[DataMember]
		public string PibDobavljaca
		{
			get { return pibDobavljaca; }
			set
			{
				pibDobavljaca = value;
				OnPropertyChanged("PibDobavljaca");
			}
		}

		[DataMember]
		public string NazivKupca
		{
			get { return nazivKupca; }
			set 
			{ 
				nazivKupca = value;
				OnPropertyChanged("NazivKupca");
			}
		}

		[DataMember]
		public double VrednostUsluge
		{
			get { return vrednostUsluge; }
			set 
			{ 
				vrednostUsluge = value; 
				OnPropertyChanged("VrednostUsluge"); 
			}
		}

		[DataMember]
		public double UkupnoRobeIUsluga
		{
			get { return ukupnoRobeIUsluga; }
			set 
			{ 
				ukupnoRobeIUsluga = value; 
				OnPropertyChanged("UkupnoRobeIUsluga"); 
			}
		}

		[DataMember]
		public double UkupanRabat
		{
			get { return ukupanRabat; }
			set 
			{ 
				ukupanRabat = value; 
				OnPropertyChanged("UkupanRabat"); 
			}
		}

		[DataMember]
		public double UkupanPorez
		{
			get { return ukupanPorez; }
			set 
			{ 
				ukupanPorez = value; 
				OnPropertyChanged("UkupanPorez"); 
			}
		}

		[DataMember]
		public string OznakaValute
		{
			get { return oznakaValute; }
			set 
			{ 
				oznakaValute = value; 
				OnPropertyChanged("OznakaValute"); 
			}
		}

		[DataMember]
		public double IznosZaUplatu
		{
			get { return iznosZaUplatu; }
			set 
			{ 
				iznosZaUplatu = value; 
				OnPropertyChanged("IznosZaUplatu"); 
			}
		}

		[DataMember]
		public string UplataNaRacun
		{
			get { return uplataNaRacun; }
			set 
			{ 
				uplataNaRacun = value; 
				OnPropertyChanged("UplatiNaRacun"); 
			}
		}

		[DataMember]
		public string AdresaKupca
		{
			get { return adresaKupca; }
			set 
			{ 
				adresaKupca = value; 
				OnPropertyChanged("AdresaKupca");
			}
		}

		[DataMember]
		public string PibKupca
		{
			get { return pibKupca; }
			set 
			{ 
				pibKupca = value; 
				OnPropertyChanged("PibKupca"); 
			}
		}

		[DataMember]
		public int BrojRacuna
		{
			get { return brojRacuna; }
			set 
			{ 
				brojRacuna = value; 
				OnPropertyChanged("BrojRacuna"); 
			}
		}

		[DataMember]
		public double VrednostRobe
		{
			get { return vrednostRobe; }
			set 
			{ 
				vrednostRobe = value; 
				OnPropertyChanged("VrednostRobe"); 
			}
		}

		[DataMember]
		public DateTime DatumRacuna
		{
			get { return datumRacuna; }
			set 
			{ 
				datumRacuna = value;
				OnPropertyChanged("DatumRacuna");
			}
		}

		[DataMember]
		public DateTime DatumValute
		{
			get { return datumValute; }
			set 
			{ 
				datumValute = value;
				OnPropertyChanged("DatumValute");
			}
		}

		[DataMember]
		public List<StavkaFakture> Stavke
		{
			get { return stavke; }
			set 
			{ 
				stavke = value;
				OnPropertyChanged("Stavke");
			}
		}
	}
}
