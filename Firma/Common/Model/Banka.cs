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
	public class Banka : ViewModelBase
	{
		private int idBanka;
		private string naziv;
		private string swift;
		private string racun;

		private List<Racun> racuni = new List<Racun>();


		public Banka()
		{

		}

		public Banka(int idBanka, string naziv, string swift, string racun)
		{
			this.idBanka = idBanka;
			this.naziv = naziv;
			this.swift = swift;
			this.racun = racun;
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
		public int IdBanka
		{
			get { return idBanka; }
			set 
			{ 
				idBanka = value; 
				OnPropertyChanged("IdBanka"); 
			}
		}

		[DataMember]
		public string Swift
		{
			get { return swift; }
			set 
			{ 
				swift = value; 
				OnPropertyChanged("Swift"); 
			}
		}

		[DataMember]
		public string Racun
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
