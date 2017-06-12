using Common.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public class DAO
	{
		public static void UpdateStanjeRacuna(string racun, double stanje)
		{
			using (SqlConnection connection = new SqlConnection(SQLConnection.ConnectionString))
			{
				connection.Open();
				string query = "UPDATE RACUN SET STANJE = @stanje WHERE RACUN = @racun";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@stanje", stanje);
					command.Parameters.AddWithValue("@racun", racun);

					command.ExecuteNonQuery();
				}

				connection.Close();
			}
		}

		public static List<Izvod> GetIzvod(string racun)
		{
			List<Izvod> izvodi = new List<Izvod>();

			using (SqlConnection connection = new SqlConnection(SQLConnection.ConnectionString))
			{
				connection.Open();
				string query = "SELECT * FROM IZVOD WHERE RACUN_DUZNIKA = @racunDuznika OR RACUN_POVERIOCA = @racunPoverioca";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@racunDuznika", racun);
					command.Parameters.AddWithValue("@racunPoverioca", racun);

					SqlDataReader reader = command.ExecuteReader();


					while (reader.Read())
					{
						Izvod izvod = new Izvod(
							reader["SVRHA_PLACANJA"].ToString(),
							reader["DUZNIK"].ToString(),
							reader["PRIMALAC"].ToString(),
							DateTime.Now,
							DateTime.Now,
							reader["RACUN_DUZNIKA"].ToString(),
							int.Parse(reader["MODEL_ZADUZENJA"].ToString()),
							reader["POZIV_NA_BROJ_ZADUZENJA"].ToString(),
							reader["RACUN_POVERIOCA"].ToString(),
							int.Parse(reader["MODEL_ODOBRENJA"].ToString()),
							reader["POZIV_NA_BROJ_ODOBRENJA"].ToString(),
							double.Parse(reader["IZNOS"].ToString()));

						izvodi.Add(izvod);
					}

					connection.Close();
				}
			}


			return izvodi;
		}

		public static void InsertIzvod(Izvod izvod, int k)
		{
			using (SqlConnection connection = new SqlConnection(SQLConnection.ConnectionString))
			{
				connection.Open();
				string query = "INSERT INTO [dbo].[IZVOD]([SVRHA_PLACANJA],[DUZNIK],[PRIMALAC],[DATUM_NALOGA],[DATUM_VALUTE],[RACUN_DUZNIKA],[MODEL_ZADUZENJA],[POZIV_NA_BROJ_ZADUZENJA],[RACUN_POVERIOCA],[MODEL_ODOBRENJA],[POZIV_NA_BROJ_ODOBRENJA],[IZNOS])VALUES" + 
					"(@svrhaPlacanja,@duznik,@primalac,@datumNaloga,@datumValute,@racunDuznika,@modelZaduzenja," + 
					"@pozivNaBrojZaduzenja,@racunPoverioca,@modelOdobrenja,@pozivNaBrojOdobrenja,@iznos)";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@svrhaPlacanja", izvod.SvrhaPlacanja);
					command.Parameters.AddWithValue("@duznik", izvod.Duznik);
					command.Parameters.AddWithValue("@primalac", izvod.Primalac);
					command.Parameters.AddWithValue("@datumNaloga", izvod.DatumNaloga);
					command.Parameters.AddWithValue("@datumValute", izvod.DatumValute);
					command.Parameters.AddWithValue("@racunDuznika", izvod.RacunDuznika);
					command.Parameters.AddWithValue("@modelZaduzenja", izvod.ModelZaduzenja);
					command.Parameters.AddWithValue("@pozivNaBrojZaduzenja", izvod.PozivNaBrojZaduzenja);
					command.Parameters.AddWithValue("@racunPoverioca", izvod.RacunPoverioca);
					command.Parameters.AddWithValue("@modelOdobrenja", izvod.ModelOdobrenja);
					command.Parameters.AddWithValue("@pozivNaBrojOdobrenja", izvod.PozivNaBrojOdobrenja);
					command.Parameters.AddWithValue("@iznos", k * izvod.Iznos);

					command.ExecuteNonQuery();
				}


				connection.Close();
			}
		}

		public static Firma GetFirmaBrojRacuna(string brojRacuna)
		{
			using (SqlConnection connection = new SqlConnection(SQLConnection.ConnectionString))
			{
				connection.Open();
				string query = "SELECT * FROM RACUN LEFT OUTER JOIN FIRMA on FIRMA.ID_FIRMA = RACUN.ID_FIRMA WHERE RACUN.RACUN = '" + brojRacuna + "'";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						Firma racun = new Firma(
							int.Parse(reader["ID_FIRMA"].ToString()),
							reader["NAZIV"].ToString(),
							reader["ADRESA"].ToString(),
							reader["PIB"].ToString(),
							null);

						return racun;
					}
				}

				connection.Close();
			}

			return null;
		}

		public static Racun GetRacunImeFirme(string imeFirme)
		{
			using (SqlConnection connection = new SqlConnection(SQLConnection.ConnectionString))
			{
				connection.Open();
				string query = "SELECT * FROM FIRMA LEFT OUTER JOIN RACUN on FIRMA.ID_FIRMA = RACUN.ID_FIRMA WHERE FIRMA.NAZIV = '" + imeFirme + "'";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						Racun racun = new Racun(
							int.Parse(reader["ID_RACUN"].ToString()),
							reader["RACUN"].ToString(),
							double.Parse(reader["STANJE"].ToString()));

						return racun;
					}
				}

				connection.Close();
			}

			return null;
		}

		public static Racun GetRacunBrojRacuna(string brojRacuna)
		{
			using (SqlConnection connection = new SqlConnection(SQLConnection.ConnectionString))
			{
				connection.Open();
				string query = "SELECT * FROM RACUN WHERE RACUN.RACUN = '" + brojRacuna + "'";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						Racun racun = new Racun(
							int.Parse(reader["ID_RACUN"].ToString()),
							reader["RACUN"].ToString(),
							double.Parse(reader["STANJE"].ToString()));

						return racun;
					}
				}

				connection.Close();
			}

			return null;
		}

		public static Banka GetBanka(string racun)
		{
			using (SqlConnection connection = new SqlConnection(SQLConnection.ConnectionString))
			{
				connection.Open();
				string query = "SELECT * FROM BANKA LEFT OUTER JOIN RACUN ON BANKA.ID_BANKA = RACUN.ID_BANKA WHERE RACUN.RACUN = '" + racun + "'";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						Common.Model.Banka banka = new Common.Model.Banka(
							int.Parse(reader["ID_BANKA"].ToString()),
							reader["NAZIV"].ToString(),
							reader["SWIFT"].ToString(),
							reader["RACUN"].ToString());

						return banka;
					}
				}

				connection.Close();
			}

			return null;
		}
	}
}
