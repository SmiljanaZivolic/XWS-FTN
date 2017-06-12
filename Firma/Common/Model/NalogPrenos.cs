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
	public class NalogPrenos
	{
		private int idNalog;
		private string idPoruke;
		private string duznik;
		private string svrhaPlacanja;
		private string primalac;
		private DateTime datumNaloga;
		private DateTime datumValute;
		private string racunDuznika;
		private int modelZaduzenja;
		private string pozivNaBrZaduzenja;
		private string racunPrimalac;
		private int modelOdobrenja;
		private int pozivNaBrOdobrenja;
		private double iznos;
		private string oznakaValute;
		private bool hitno;

		
		public NalogPrenos()
		{

		}

		public NalogPrenos(int idNalog, string idPoruke, string duznik, 
			string svrhaPlacanja, string primalac, DateTime datumNaloga,
			DateTime datumValute, string racunDuznika, int modelZaduzenja,
			string pozivNaBrZaduzenja, string racunPrimalac, int modelOdobrenja,
			int pozivNaBrOdobrenja, double iznos, string oznakaValute,
			bool hitno)
		{
			this.idNalog = idNalog;
			this.idPoruke = idPoruke;
			this.duznik = duznik;
			this.svrhaPlacanja = svrhaPlacanja;
			this.primalac = primalac;
			this.datumNaloga = datumNaloga;
			this.datumValute = datumValute;
			this.racunDuznika = racunDuznika;
			this.modelZaduzenja = modelZaduzenja;
			this.pozivNaBrZaduzenja = pozivNaBrZaduzenja;
			this.racunPrimalac = racunPrimalac;
			this.modelOdobrenja = modelOdobrenja;
			this.pozivNaBrOdobrenja = pozivNaBrOdobrenja;
			this.iznos = iznos;
			this.oznakaValute = oznakaValute;
			this.hitno = hitno;
		}

		[DataMember]
		public int IdNalog
		{
			get { return idNalog; }
			set 
			{ 
				idNalog = value;
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

		[DataMember]
		public string Duznik
		{
			get { return duznik; }
			set 
			{ 
				duznik = value;
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
		public string Primalac
		{
			get { return primalac; }
			set 
			{ 
				primalac = value; 
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
		public DateTime DatumValute
		{
			get { return datumValute; }
			set 
			{ 
				datumValute = value;
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
		public int ModelZaduzenja
		{
			get { return modelZaduzenja; }
			set 
			{ 
				modelZaduzenja = value;
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
		public string RacunPrimalac
		{
			get { return racunPrimalac; }
			set 
			{ 
				racunPrimalac = value;
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
		public int PozivNaBrOdobrenja
		{
			get { return pozivNaBrOdobrenja; }
			set 
			{
				pozivNaBrOdobrenja = value;
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
		public string OznakaValute
		{
			get { return oznakaValute; }
			set 
			{
				oznakaValute = value; 
			}
		}

		[DataMember]
		public bool Hitno
		{
			get { return hitno; }
			set 
			{
				hitno = value; 
			}
		}
	}
}
