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
	public class Firma : ViewModelBase
	{
		private int idFirma;
		private string naziv;
		private string adresa;
		private string pib;
		private Racun racun;


		public Firma()
		{

		}

		public Firma(int idFirma, string naziv, string adresa, string pib, Racun racun)
		{
			this.idFirma = idFirma;
			this.naziv = naziv;
			this.adresa = adresa;
			this.pib = pib;
			this.racun = racun;
		}

		[DataMember]
		public int IdFirma
		{
			get { return idFirma; }
			set 
			{ 
				idFirma = value; 
				OnPropertyChanged("IdFirma"); 
			}
		}

		[DataMember]
		public string Naziv
		{
			get { return naziv; }
			set 
			{ 
				naziv = value;
				OnPropertyChanged("Naziv"); 
			}
		}

		[DataMember]
		public string Adresa
		{
			get { return adresa; }
			set 
			{ 
				adresa = value; OnPropertyChanged("Adresa"); 
			}
		}

		[DataMember]
		public string Pib
		{
			get { return pib; }
			set 
			{ 
				pib = value; 
				OnPropertyChanged("Pib"); 
			}
		}

		[DataMember]
		public Racun Racun
		{
			get { return racun; }
			set 
			{ 
				racun = value;
				OnPropertyChanged("Racun"); 
			}
		}
	}
}
