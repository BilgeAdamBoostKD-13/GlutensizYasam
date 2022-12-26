using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Repositories
{
    public class GunlukPlanService
    {
        GunlukPlanRepository gunlukPlanRepository;

        public GunlukPlanService()
        {
            gunlukPlanRepository = new GunlukPlanRepository();
        }

        public bool Insert(GunlukPlan gunlukPlan)
        {
            return gunlukPlanRepository.Insert(gunlukPlan);
        }


    }
}
