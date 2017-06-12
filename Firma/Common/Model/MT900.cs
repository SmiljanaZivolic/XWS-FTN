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
	public class MT900 
	{
		private string idPoruke;
		private string swiftBankeDuznika;
		private string obracunskiBankeDuznika;
		private string idPorukeNaloga;
		private DateTime datumValute;
		private double iznos;
		private string sifraValute;

		
		public MT900()
		{

		}
		
		public MT900(string idPoruke, string swiftBankeDuznika, string obracunskiBankeDuznika,
			string idPorukeNaloga, DateTime datumValute, double iznos, string sifraValute)
		{
			this.idPoruke = idPoruke;
			this.swiftBankeDuznika = swiftBankeDuznika;
			this.obracunskiBankeDuznika = obracunskiBankeDuznika;
			this.idPorukeNaloga = idPorukeNaloga;
			this.datumValute = datumValute;
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
		public string ObracunskiBankeDuznika
		{
			get { return obracunskiBankeDuznika; }
			set 
			{
				obracunskiBankeDuznika = value; 
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
		public string IdPorukeNaloga
		{
			get { return idPorukeNaloga; }
			set 
			{ 
				idPorukeNaloga = value; 
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
		public string SwiftBankeDuznika
		{
			get { return swiftBankeDuznika; }
			set 
			{
				swiftBankeDuznika = value;
			}
		}

	}
}
