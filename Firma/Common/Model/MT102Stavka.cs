﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
	[DataContract]
	public class MT102Stavka
	{
		private string idNalogaZaPlacanje;
		private string duznikNalogodavac;
		private string svrhaPlacanja;
		private string primalacPoverilac;
		private DateTime datumNaloga;
		private string racunDuznika;
		private int modelZaduzenja;
		private string pozivNaBrZaduzenja;
		private string racunPoverioca;
		private int modelOdobrenja;
		private string pozivNaBrOdobrenja;
		private double iznos;
		private string sifraValutee;

		public MT102Stavka(string idNalogaZaPlacanje, string duznikNalogodavac, string svrhaPlacanja,
			string primalacPoverilac, DateTime datumNaloga, string racunDuznika,
			int modelZaduzenja, string pozivNaBrZaduzenja, string racunPoverioca,
			int modelOdobrenja, string pozivNaBrOdobrenja, double iznos,
			string sifraValutee)
		{

			this.idNalogaZaPlacanje = idNalogaZaPlacanje;
			this.duznikNalogodavac = duznikNalogodavac;
			this.svrhaPlacanja = svrhaPlacanja;
			this.primalacPoverilac = primalacPoverilac;
			this.datumNaloga = datumNaloga;
			this.racunDuznika = racunDuznika;
			this.modelZaduzenja = modelZaduzenja;
			this.pozivNaBrZaduzenja = pozivNaBrZaduzenja;
			this.racunPoverioca = racunPoverioca;
			this.modelOdobrenja = modelOdobrenja;
			this.pozivNaBrOdobrenja = pozivNaBrOdobrenja;
			this.iznos = iznos;
			this.sifraValutee = sifraValutee;
		}

		[DataMember]
		public string SifraValutee
		{
			get { return sifraValutee; }
			set
			{
				sifraValutee = value;
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
		public string IdNalogaZaPlacanje
		{
			get { return idNalogaZaPlacanje; }
			set
			{
				idNalogaZaPlacanje = value;
			}
		}
	}
}
