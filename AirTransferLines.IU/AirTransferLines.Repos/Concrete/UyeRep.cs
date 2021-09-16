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
    public class UyeRep : BaseRepository<Uye>, IUyeRep
    {
        public List<UyeDTO> UyeDetay()
        {
            return Set().Select(uye => new UyeDTO
            {
                UyeID = uye.uyeID,
                UyeAd = uye.uyeAd,
                UyeSoyad = uye.uyeSoyad,
                //SehirID = uye.SehirID,
                //SehirAd = se.SehirAd,
                //UlkeID = uye.UlkeID,
                //UlkeAd = u.UlkeAdi,
                Adres = uye.adres,
                Email = uye.email,
                Telefon = uye.telefon,
                Sifre = uye.sifre,
            }).ToList();
        }
    }
}
