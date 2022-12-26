using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Repositories
{
    public class GunlukPlanRepository
    {
        GlutensizYasamDbContext context;
        public GunlukPlanRepository()
        {
            context = new GlutensizYasamDbContext();
        }

        public List<GunlukPlan> GetByKullaniciId(int kullaniciID)
        {
            return context.GunlukPlanlar.Where(a=>a.KullaniciId == kullaniciID).ToList();
        }

        public GunlukPlan GetByGunlukPlanID(int gunlukPlanID)
        {
            return context.GunlukPlanlar.Find(gunlukPlanID);
        }

        public bool Insert(GunlukPlan gunlukPlan)
        {
            context.GunlukPlanlar.Add(gunlukPlan);
            return context.SaveChanges() > 0;
        }



        //public bool Update(GunlukPlan gunlukPlan)
        //{
        //    GunlukPlan updateGunlukPlan = GetByGunlukPlanID(gunlukPlan.ID);
        //    updateGunlukPlan.Tarih = gunlukPlan.Tarih;
        //    updateGunlukPlan.Kahvalti = gunlukPlan.Kahvalti;
        //    updateGunlukPlan.OgleYemegi = gunlukPlan.OgleYemegi;
        //    updateGunlukPlan.AraOgun = gunlukPlan.AraOgun;
        //    updateGunlukPlan.AksamYemegi = gunlukPlan.AksamYemegi;
        //    return context.SaveChanges() > 0;
        //}
    }
}
