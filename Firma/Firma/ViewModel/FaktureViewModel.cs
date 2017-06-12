using Common;
using Common.Model;
using Common.ServiceContract;
using Common.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Firma.ViewModel
{
	public class FaktureViewModel : ViewModelBase
	{
		private List<Faktura> fakture = new List<Faktura>();
		private Faktura selektovanaFaktura;
		private RelayCommand platiCommand;
		private Racun racun;
		private string imeFirme;

		public FaktureViewModel(string imeFirme)
		{
			this.imeFirme = imeFirme;
			UcitajFakture();
			racun = DAO.GetRacunImeFirme(imeFirme);
		}

		public RelayCommand PlatiCommand
		{
			get { return platiCommand ?? ( platiCommand  = new RelayCommand(param => PlatiCommandExecute(), param => PlatiCommandCanExeute())); }
		}

		public List<Faktura> Fakture
		{
			get { return fakture; }
			set 
			{ 
				fakture = value;
				OnPropertyChanged("Fakture");
			}
		}

		public Faktura SelektovanaFaktura
		{
			get { return selektovanaFaktura; }
			set 
			{
				selektovanaFaktura = value;
				OnPropertyChanged("SelektovanaFaktura");
			}
		}

		public void PlatiCommandExecute()
		{
			NalogPrenos nalog = new NalogPrenos(
				-1,
				"test",
				SelektovanaFaktura.NazivKupca,
				"Svrha placanja",
				SelektovanaFaktura.NazivDobavljaca,
				DateTime.Now,
				DateTime.Now,
				racun.BrojRacun,
				97,
				"poziv",
				SelektovanaFaktura.UplataNaRacun,
				97,
				4464,
				SelektovanaFaktura.UkupnoRobeIUsluga,
				"RSD",
				false
			);

			Banka banka = DAO.GetBanka(racun.BrojRacun);

			ChannelFactory<IBank> factory = new ChannelFactory<IBank>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:9000/" + banka.Naziv));
			IBank proxy = factory.CreateChannel();

			try
			{
				proxy.SendNalogPrenos(nalog);
			}
			catch (Exception e)
			{ }
		}

		public bool PlatiCommandCanExeute()
		{
			return selektovanaFaktura != null;
		}

		private void UcitajFakture()
		{
			List<Faktura> input = new List<Faktura>();

			using(SqlConnection connection = new SqlConnection(SQLConnection.ConnectionString))
			{
				connection.Open();
				string query = "SELECT * FROM FAKTURA WHERE NAZIV_DOBAVLJACA = '" + imeFirme + "'";

				using(SqlCommand command = new SqlCommand(query, connection))
				{
					SqlDataReader reader = command.ExecuteReader();

					while(reader.Read())
					{
						Faktura faktura = new Faktura(
							int.Parse(reader["ID_FAKTURA"].ToString()),
							reader["ID_PORUKE"].ToString(),
							reader["NAZIV_DOBAVLJACA"].ToString(),
							reader["ADRESA_DOBAVLJACA"].ToString(),
							reader["PIB_DOBAVLJACA"].ToString(),
							reader["NAZIV_KUPCA"].ToString(),
							reader["ADRESA_KUPCA"].ToString(),
							reader["PIB_KUPCA"].ToString(),
							int.Parse(reader["BROJ_RACUNA"].ToString()),
							double.Parse(reader["VREDNOST_ROBE"].ToString()),
							double.Parse(reader["VREDNOST_USLUGE"].ToString()),
							double.Parse(reader["UKUPNO_ROBE_I_USLUGA"].ToString()),
							double.Parse(reader["UKUPAN_RABAT"].ToString()),
							double.Parse(reader["UKUPAN_POREZ"].ToString()),
							reader["OZNAKA_VALUTE"].ToString(),
							double.Parse(reader["IZNOS_ZA_UPLATU"].ToString()),
							reader["UPLATA_NA_RACUN"].ToString(),
							DateTime.Now,
							DateTime.Now
							);

						input.Add(faktura);
					}
				}

				connection.Close();
			}

			Fakture = input;
		}
	}
}
