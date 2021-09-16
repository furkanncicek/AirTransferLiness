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
    public class AcenteRep : BaseRepository<Acente>, IAcenteRep
    {
        public List<AcenteDTO> AcenteListe()
        {
            return Set().Select(ac => new AcenteDTO
            {
                AcenteID = ac.AcenteID,
              //  UlkeID = ac.Ulke.UlkeID,
              //  SehirID = ac.Sehir.SehirID,
                SehirAd = ac.Sehir.SehirAd,
                UlkeAdi = ac.Ulke.UlkeAd,
                Email = ac.Email,
                AcenteAdi = ac.AcenteAdi,
                Adres = ac.Adres,
                FaturaAdres = ac.FaturaAdres,
                Iban = ac.Iban,
                FirmaUnvan = ac.FirmaUnvan,
                Yetkili = ac.Yetkili,
                Telefon = ac.Telefon,
                YetkiliTel = ac.YetkiliTel,
                YetkiliEmail = ac.YetkiliEmail,
                Notlar = ac.Notlar,
                VergiDaire = ac.VergiDaire,
                VergiDaireNo = ac.VergiDaireNo,
                Sifre = ac.Sifre,
            }).ToList();
        }
    }
}
