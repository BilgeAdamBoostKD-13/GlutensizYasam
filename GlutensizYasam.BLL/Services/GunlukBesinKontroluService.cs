﻿using GlutensizYasam.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.BLL.Services
{
    public class GunlukBesinKontroluService
    {
        GunlukBesinKontroluRepository gunlukBesinKontroluRepository;

        public GunlukBesinKontroluService()
        {
            gunlukBesinKontroluRepository = new GunlukBesinKontroluRepository();
        }
    
    }
}
