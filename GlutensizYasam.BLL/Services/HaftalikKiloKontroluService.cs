﻿using GlutensizYasam.DAL.Repositories;
using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.BLL.Services
{
    public class HaftalikKiloKontroluService
    {
        HaftalikKiloKontroluRepostory haftalikKiloKontroluRepostory;
        public HaftalikKiloKontroluService()
        {
            haftalikKiloKontroluRepostory = new HaftalikKiloKontroluRepostory();
        }


        public bool Insert(HaftalikKiloKontrolu haftalikKiloKontrolu)
        {
            return haftalikKiloKontroluRepostory.Insert(haftalikKiloKontrolu);
        }
    }
}
