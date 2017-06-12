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
	public class StavkaFakture : ViewModelBase
	{
		private int idStavka;
		private int redniBroj;
		private string nazivRobe;
		private double kolicina;
		private string jedinicaMere;
		private double jedinicnaCena;
		private double vrednost;
		private double procenatRabata;
		private double iznosRabata;
		private double ukupanPorez;

		
		public StavkaFakture()
		{

		}

		public StavkaFakture(int idStavka, int redniBroj, string nazivRobe,
			double kolicina, string jedinicaMere, double jedinicnaCena,
			double vrednost, double procenatRabata, double iznosRabata,
			double ukupanPorez)
		{
			this.idStavka = idStavka;
			this.redniBroj = redniBroj;
			this.nazivRobe = nazivRobe;
			this.kolicina = kolicina;
			this.jedinicaMere = jedinicaMere;
			this.jedinicnaCena = jedinicnaCena;
			this.vrednost = vrednost;
			this.procenatRabata = procenatRabata;
			this.iznosRabata = iznosRabata;
			this.ukupanPorez = ukupanPorez;
		}

		[DataMember]
		public int IdStavka
		{
			get { return idStavka; }
			set 
			{ 
				idStavka = value; 
				OnPropertyChanged("IdStavka"); 
			}
		}

		[DataMember]
		public int RedniBroj
		{
			get { return redniBroj; }
			set 
			{ 
				redniBroj = value; 
				OnPropertyChanged("RedniBroj"); 
			}
		}

		[DataMember]
		public string NazivRobe
		{
			get { return nazivRobe; }
			set 
			{ 
				nazivRobe = value; 
				OnPropertyChanged("NazivRobe"); 
			}
		}

		[DataMember]
		public double Kolicina
		{
			get { return kolicina; }
			set 
			{ 
				kolicina = value; 
				OnPropertyChanged("Kolicina"); 
			}
		}

		[DataMember]
		public string JedinicaMere
		{
			get { return jedinicaMere; }
			set 
			{ 
				jedinicaMere = value; 
				OnPropertyChanged("JedinicaMere"); 
			}
		}

		[DataMember]
		public double JedinicnaCena
		{
			get { return jedinicnaCena; }
			set 
			{ 
				jedinicnaCena = value;
				OnPropertyChanged("JedinicnaCena"); 
			}
		}

		[DataMember]
		public double Vrednost
		{
			get { return vrednost; }
			set 
			{ 
				vrednost = value; 
				OnPropertyChanged("Vrednost"); 
			}
		}

		[DataMember]
		public double ProcenatRabata
		{
			get { return procenatRabata; }
			set 
			{ 
				procenatRabata = value; 
				OnPropertyChanged("ProcenatRabata");
			}
		}

		[DataMember]
		public double IznosRabata
		{
			get { return iznosRabata; }
			set 
			{ 
				iznosRabata = value; 
				OnPropertyChanged("IznosRabata"); 
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
	}
}
