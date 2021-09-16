using AirTransferLines.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Repos.Abstract
{
   public interface ITransferRep
    {
        List<TransferDTO> TransferDetay();
    }
}
