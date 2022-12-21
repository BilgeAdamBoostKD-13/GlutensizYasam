using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Repositories
{
    public class GunlukBesinKontroluRepository
    {
        GlutensizYasamDbContext context;
        public GunlukBesinKontroluRepository()
        {
            context = new GlutensizYasamDbContext();
        }

        public GunlukBesinKontrolu GetByGunlukBesinKontrolu(int GunlukBesinKontroluId)
        {
            return context.gunlukBesinKontrolleri.Find(GunlukBesinKontroluId);
        }

        public bool Insert(GunlukBesinKontrolu gunlukBesinKontrolu)
        {
            context.gunlukBesinKontrolleri.Add(gunlukBesinKontrolu);
            return context.SaveChanges() > 0;
        }
    }
}
