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
    public class TransferRep : BaseRepository<Transfer>, ITransferRep
    {
        public List<TransferDTO> TransferDetay()
        {
            return Set().Select(tr => new TransferDTO
            {
                TransferID = tr.transferID,
                UlkeID = tr.Ulke.UlkeID,
                SehirID = tr.Sehir.SehirID,
                SehirAd = tr.Sehir.SehirAd,
                UlkeAdi = tr.Ulke.UlkeAd,
                //UyeSoyad = uye.UyeSoyad,
                AracAdi = tr.Arac.aracAdi,
                //Email = uye.Email,
                Nereden = tr.nereden,
                Nereye = tr.nereye,
                KisiSayisi =Convert.ToInt32(tr.kisiSayisi),
                BagajSayisi =Convert.ToInt32(tr.bagajSayisi),
                Tarih =Convert.ToDateTime(tr.tarih),
                Saat =Convert.ToDateTime(tr.saat),
                Km =Convert.ToInt32(tr.km),
                SureSaat = tr.sureSaat,
                Fiyat =Convert.ToDecimal(tr.fiyat),
                EkstrasızFiyat =Convert.ToDecimal(tr.ekstrasızFiyat),
                Doviz = tr.doviz,
                
            }).ToList();
        }
    }
}
