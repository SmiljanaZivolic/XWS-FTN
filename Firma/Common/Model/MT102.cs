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
	public class MT102
	{
		private string idPoruke;
		private string swiftDuznika;
		private string obracunskiDuznika;
		private string swiftPoverioca;
		private string obracunskiPoverioca;
		private double ukupanIznos;
		private string sifraValute;
		private DateTime datumValute;
		private DateTime datum;
		private List<MT102Stavka> stavke = new List<MT102Stavka>();

		public MT102(string idPoruke, string swiftDuznika, string obracunskiDuznika,
			string swiftPoverioca, string obracunskiPoverioca, double ukupanIznos,
			string sifraValute, DateTime datumValute, DateTime datum)
		{
			this.idPoruke = idPoruke;
			this.swiftDuznika = swiftDuznika;
			this.obracunskiDuznika = obracunskiDuznika;
			this.swiftPoverioca = swiftPoverioca;
			this.obracunskiPoverioca = obracunskiPoverioca;
			this.ukupanIznos = ukupanIznos;
			this.sifraValute = sifraValute;
			this.datumValute = datumValute;
			this.datum = datum;
		}

		[DataMember]
		public List<MT102Stavka> Stavke
		{
			get { return stavke; }
			set { stavke = value; }
		}

		[DataMember]
		public DateTime Datum
		{
			get { return datum; }
			set 
			{ 
				datum = value;
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
		public string SifraValute
		{
			get { return sifraValute; }
			set 
			{ 
				sifraValute = value;
			}
		}

		[DataMember]
		public double UkupanIznos
		{
			get { return ukupanIznos; }
			set 
			{ 
				ukupanIznos = value;
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
		public string SwiftDuznika
		{
			get { return swiftDuznika; }
			set
			{
				swiftDuznika = value;
			}
		}

		[DataMember]
		public string ObracunskiDuznika
		{
			get { return obracunskiDuznika; }
			set 
			{ 
				obracunskiDuznika = value;
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
		public string ObracunskiPoverioca
		{
			get { return obracunskiPoverioca; }
			set 
			{ 
				obracunskiPoverioca = value;
			}
		}
	}
}
