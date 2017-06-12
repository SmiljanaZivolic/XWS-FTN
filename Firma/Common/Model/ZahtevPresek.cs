using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
	[DataContract]
	public class ZahtevPresek
	{
		private string brojRacuna;
		private DateTime datum;
		private int redniBroj;

		public ZahtevPresek(string brojRacuna, DateTime datum, int redniBroj)
		{
			this.brojRacuna = brojRacuna;
			this.datum = datum;
			this.redniBroj = redniBroj;
		}

		[DataMember]
		public string BrojRacuna
		{
			get { return brojRacuna; }
			set { brojRacuna = value; }
		}

		[DataMember]
		public DateTime Datum
		{
			get { return datum; }
			set { datum = value; }
		}

		[DataMember]
		public int RedniBroj
		{
			get { return redniBroj; }
			set { redniBroj = value; }
		}
	}
}
