using Common;
using Common.Model;
using Common.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CentralnaBanka
{
	public class CentralnaBankaServer : ICentralnaBanka
	{
		public MT900 RTGS(MT103 mt103)
		{
			Banka bankaDuznika = DAO.GetBanka(mt103.RacunDuznika);
			Banka bankaPrimaoca = DAO.GetBanka(mt103.RacunPoverioca);

			Firma duznik = DAO.GetFirmaBrojRacuna(mt103.RacunDuznika);
			Firma primalac = DAO.GetFirmaBrojRacuna(mt103.RacunPoverioca);

			MT900 rt900 = new MT900("idPoruka",
				bankaDuznika.Swift,
				bankaDuznika.Racun,
				mt103.IdPoruke,
				mt103.DatumValute,
				mt103.Iznos,
				mt103.SifraValute
			);

			MT910 mt910 = new MT910(
				"idPoruke",
				bankaPrimaoca.Swift,
				bankaPrimaoca.Racun,
				mt103.IdPoruke,
				mt103.DatumValute,
				mt103.Iznos,
				mt103.SifraValute
			);

			ChannelFactory<IBank> factory = new ChannelFactory<IBank>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:9000/" + bankaPrimaoca.Naziv));
			IBank proxy = factory.CreateChannel();

			try
			{
				proxy.ObradiRTGS(mt103, mt910);
			}
			catch (Exception e)
			{ }

			Izvod izvod = new Izvod(mt103.SvrhaPlacanja, mt103.DuznikNalogodavac, mt103.PrimalacPoverilac, mt103.DatumNaloga,
				mt103.DatumValute, mt103.RacunDuznika, mt103.ModelZaduzenja, mt103.PozivNaBrZaduzenja,
				mt103.RacunPoverioca, mt103.ModelOdobrenja, mt103.PozivNaBrOdobrenja, mt103.Iznos);

			DAO.InsertIzvod(izvod, 1);

			return rt900;
		}

		private void DoClearing(List<MT102> mt102s)
		{
			foreach(MT102 mt102 in mt102s)
			{
				foreach(MT102Stavka stavka in mt102.Stavke)
				{
					Banka bankaDuznika = DAO.GetBanka(stavka.RacunDuznika);
					Banka bankaPrimaoca = DAO.GetBanka(stavka.RacunPoverioca);

					Firma duznik = DAO.GetFirmaBrojRacuna(stavka.RacunDuznika);
					Firma primalac = DAO.GetFirmaBrojRacuna(stavka.RacunPoverioca);

					MT900 rt900 = new MT900("idPoruka",
						bankaDuznika.Swift,
						bankaDuznika.Racun,
						mt102.IdPoruke,
						mt102.DatumValute,
						stavka.Iznos,
						mt102.SifraValute
					);

					MT910 mt910 = new MT910(
						"idPoruke",
						bankaPrimaoca.Swift,
						bankaPrimaoca.Racun,
						mt102.IdPoruke,
						mt102.DatumValute,
						stavka.Iznos,
						mt102.SifraValute
					);

					ChannelFactory<IBank> factory = new ChannelFactory<IBank>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:9000/" + bankaPrimaoca.Naziv));
					IBank proxy = factory.CreateChannel();

					try
					{
						proxy.ObradiClearing(stavka, mt910);
					}
					catch (Exception e)
					{ }

					Izvod izvod = new Izvod(stavka.SvrhaPlacanja, stavka.DuznikNalogodavac, stavka.PrimalacPoverilac, stavka.DatumNaloga,
					stavka.DatumNaloga, stavka.RacunDuznika, stavka.ModelZaduzenja, stavka.PozivNaBrZaduzenja,
					stavka.RacunPoverioca, stavka.ModelOdobrenja, stavka.PozivNaBrOdobrenja, stavka.Iznos);

					DAO.InsertIzvod(izvod, 1);
				}
			}
		}

		public void Clearing(List<MT102> mt102s)
		{
			Thread myNewThread = new Thread(() => DoClearing(mt102s));
			myNewThread.Start();
		}
	}
}
