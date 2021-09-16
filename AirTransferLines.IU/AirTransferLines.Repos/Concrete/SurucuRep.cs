using AirTransferLines.Core;

using AirTransferLines.Dall;
using AirTransferLines.Dto;
using AirTransferLines.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Repos.Concrete
{
    public class SurucuRep : BaseRepository<Surucu>, ISurucuRep
    {
        public List<SurucuDTO> SurucuDetay()
        {
            return Set().Select(su => new SurucuDTO
            {
                SurucuID = su.surucuID,
                UlkeID = su.Ulke.UlkeID,
                UlkeAdi=su.Ulke.UlkeAd,
                SehirID = su.Sehir.SehirID,
                SehirAd = su.Sehir.SehirAd,
                AcenteAd = su.Acente.AcenteAdi,
                SurucuAdi = su.surucuAdi,
                Telefon = su.telefon,
                Plaka = su.plaka,
                KayıtTarih = Convert.ToDateTime(su.kayıtTarih),
                SonLogin = Convert.ToDateTime(su.sonLogin),
                TcKimlikNo = su.tcKimlikNo,
                Adres = su.adres,
                Sifre = su.sifre,
                SurucuTip =Convert.ToInt32(su.surucuTip),
                SurucuKomisyon = Convert.ToInt32(su.surucuKomisyon),
                Sozlesme = Convert.ToInt32(su.sozlesme),
                SozlesmeOnayTarih = Convert.ToDateTime(su.sozlesmeOnayTarih),
                VergiDaire = su.vergiDaire,
                VergiDaireNo = su.vergiDaireNo,
                Iban = su.ıban,
                FaturaBilgisi = su.faturaBilgisi,
                Kredi = Convert.ToDecimal(su.kredi),
                Notlar = su.notlar,
                DilAdi = su.Dil.dilAdi,
                DilID = su.Dil.dilID,
                AcenteID = su.Acente.AcenteID
            }).ToList();
        }
    }
}
