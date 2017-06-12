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
	public class Racun : ViewModelBase
	{
		private int idRacun;
		private string racun;
		private double stanje;

		public Racun()
		{

		}

		public Racun(int idRacun, string racun, double stanje)
		{
			this.idRacun = idRacun;
			this.racun = racun;
			this.stanje = stanje;
		}

		[DataMember]
		public int IdRacun
		{
			get { return idRacun; }
			set 
			{ 
				idRacun = value; 
				OnPropertyChanged("IdRacun"); 
			}
		}

		[DataMember]
		public string BrojRacun
		{
			get { return racun; }
			set 
			{ 
				racun = value; 
				OnPropertyChanged("Racunn"); 
			}
		}

		[DataMember]
		public double Stanje
		{
			get { return stanje; }
			set
			{
				stanje = value;
				OnPropertyChanged("Stanje");
			}
		}
	}
}
