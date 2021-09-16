﻿using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Business.Abstract
{
   public interface ISurucuService
    {
        List<Surucu> GetAll();
        Surucu GetByID(int ID);
        void Add(Surucu entity);
        void Update(Surucu entity);
        void Delete(Surucu entity);
        List<SurucuDTO> GetSurucuDetails();
    }
}
