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
	public class MT910
	{
		private string idPoruke;
		private string swiftBankePoverioca;
		private string obracunskiBankePoverioca;
		private string idPorukeNaloga;
		private DateTime datumValute;
		private double iznos;
		private string sifraValute;


		public MT910()
		{

		}

		public MT910(string idPoruke, string swiftBankePoverioca, string obracunskiBankePoverioca,
			string idPorukeNaloga, DateTime datumValute, double iznos, string sifraValute)
		{
			this.idPoruke = idPoruke;
			this.swiftBankePoverioca = swiftBankePoverioca;
			this.obracunskiBankePoverioca = obracunskiBankePoverioca;
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
		public string ObracunskiBankePoverioca
		{
			get { return obracunskiBankePoverioca; }
			set
			{
				obracunskiBankePoverioca = value;
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
		public string SwiftBankePoverioca
		{
			get { return swiftBankePoverioca; }
			set
			{
				swiftBankePoverioca = value;
			}
		}

	}
}
