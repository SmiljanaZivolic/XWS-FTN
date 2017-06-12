using Common.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
	[DataContract]
	public class MT103
	{
		private string idPoruke;
		private string swiftDuznika;
		private string obracunskiRacunDuznika;
		private string swiftPoverioca;
		private string obracunskiRacunBankePoverioca;
		private string duznikNalogodavac;
		private string svrhaPlacanja;
		private string primalacPoverilac;
		private DateTime datumNaloga;
		private DateTime datumValute;
		private string racunDuznika;
		private int modelZaduzenja;
		private string pozivNaBrZaduzenja;
		private string racunPoverioca;
		private int modelOdobrenja;
		private string pozivNaBrOdobrenja;
		private double iznos;
		private string sifraValute;

		
		public MT103()
		{

		}
		
		public MT103(string idPoruke, string swiftDuznika,
			string obracunskiRacunDuznika, string swiftPoverioca,
			string obracunskiRacunBankePoverioca, string duznikNalogodavac,
			string svrhaPlacanja, string primalacPoverilac, DateTime datumNaloga,
			DateTime datumValute, string racunDuznika, int modelZaduzenja, 
			string pozivNaBrZaduzenja, string racunPoverioca, int modelOdobrenja,
			string pozivNaBrOdobrenja, double iznos, string sifraValute)
		{
			this.idPoruke = idPoruke;
			this.swiftDuznika = swiftDuznika;
			this.obracunskiRacunDuznika = obracunskiRacunDuznika;
			this.swiftPoverioca = swiftPoverioca;
			this.obracunskiRacunBankePoverioca = obracunskiRacunBankePoverioca;
			this.duznikNalogodavac = duznikNalogodavac;
			this.svrhaPlacanja = svrhaPlacanja;
			this.primalacPoverilac = primalacPoverilac;
			this.datumNaloga = datumNaloga;
			this.datumValute = datumValute;
			this.racunDuznika = racunDuznika;
			this.modelZaduzenja = modelZaduzenja;
			this.pozivNaBrZaduzenja = pozivNaBrZaduzenja;
			this.racunPoverioca = racunPoverioca;
			this.modelOdobrenja = modelOdobrenja;
			this.pozivNaBrOdobrenja = pozivNaBrOdobrenja;
			this.iznos = iznos;
			this.sifraValute = sifraValute;
		}

		[DataMember]
		public string SifraValute
		{
			get { return sifraValute; }
			set 
			{ 
				sifraValute = value;
			}
		}

		[DataMember]
		public double Iznos
		{
			get { return iznos; }
			set 
			{ 
				iznos = value;
			}
		}

		[DataMember]
		public string PozivNaBrOdobrenja
		{
			get { return pozivNaBrOdobrenja; }
			set 
			{ 
				pozivNaBrOdobrenja = value;
			}
		}

		[DataMember]
		public int ModelOdobrenja
		{
			get { return modelOdobrenja; }
			set
			{
				modelOdobrenja = value;
			}
		}

		[DataMember]
		public string RacunPoverioca
		{
			get { return racunPoverioca; }
			set
			{
				racunPoverioca = value;
			}
		}

		[DataMember]
		public string PozivNaBrZaduzenja
		{
			get { return pozivNaBrZaduzenja; }
			set
			{ 
				pozivNaBrZaduzenja = value;
			}
		}

		[DataMember]
		public int ModelZaduzenja
		{
			get { return modelZaduzenja; }
			set 
			{ 
				modelZaduzenja = value;
			}
		}

		[DataMember]
		public string RacunDuznika
		{
			get { return racunDuznika; }
			set 
			{ 
				racunDuznika = value;
			}
		}

		[DataMember]
		public DateTime DatumValute
		{
			get { return datumValute; }
			set
			{ 
				datumValute = value;
			}
		}

		[DataMember]
		public DateTime DatumNaloga
		{
			get { return datumNaloga; }
			set 
			{
				datumNaloga = value;
			}
		}

		[DataMember]
		public string PrimalacPoverilac
		{
			get { return primalacPoverilac; }
			set 
			{ 
				primalacPoverilac = value;
			}
		}

		[DataMember]
		public string SvrhaPlacanja
		{
			get { return svrhaPlacanja; }
			set 
			{ 
				svrhaPlacanja = value;
			}
		}

		[DataMember]
		public string DuznikNalogodavac
		{
			get { return duznikNalogodavac; }
			set 
			{ 
				duznikNalogodavac = value;
			}
		}

		[DataMember]
		public string ObracunskiRacunBankePoverioca
		{
			get { return obracunskiRacunBankePoverioca; }
			set 
			{ 
				obracunskiRacunBankePoverioca = value;
			}
		}

		[DataMember]
		public string SwiftPoverioca
		{
			get { return swiftPoverioca; }
			set 
			{ 
				swiftPoverioca = value;
			}
		}

		[DataMember]
		public string ObracunskiRacunDuznika
		{
			get { return obracunskiRacunDuznika; }
			set 
			{ 
				obracunskiRacunDuznika = value;
			}
		}

		[DataMember]
		public string SwiftDuznika
		{
			get { return swiftDuznika; }
			set 
			{ 
				swiftDuznika = value;
			}
		}

		[DataMember]
		public string IdPoruke
		{
			get { return idPoruke; }
			set
			{ 
				idPoruke = value;
			}
		}
	}
}
