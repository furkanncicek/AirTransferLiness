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
    public class RezervasyonRep : BaseRepository<Rezervasyon>, IRezervasyonRep
    {
        public List<RezervasyonDTO> RezervasyonDetay()
        {
            return Set().Select(re => new RezervasyonDTO
            {
                RezervasyonID = re.rezervasyonID,
               // AcenteID = re.acentaID,
                UyeID = re.Uye.uyeID,
                UyeAd = re.Uye.uyeAd,
                UyeSoyad = re.Uye.uyeSoyad,
                //AcenteAd = re.acentaID.AcenteAdi,
                KayıtTarih = Convert.ToDateTime(re.kayıtTarih),
                Fiyat =Convert.ToDecimal( re.tlFiyat),
                EkstrasızFiyat = Convert.ToDecimal(re.ekstrasızFiyat),
                EkstrasızTlFiyat = Convert.ToDecimal(re.tlEkstrasızFiyat),
                TlFiyat = Convert.ToDecimal(re.tlFiyat),
                Doviz = re.doviz,
                EuroKur = Convert.ToDecimal(re.euroKur),
                UsdKur = Convert.ToDecimal(re.usdKur),
                IndirimliFiyat = Convert.ToDecimal(re.indirimliFiyat),
                Telefon = re.Uye.telefon,
                Email = re.Uye.email,
                
            }).ToList();
        }
    }
}
