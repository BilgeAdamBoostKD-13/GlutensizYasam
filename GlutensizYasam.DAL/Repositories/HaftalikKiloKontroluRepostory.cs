using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Repositories
{
    public class HaftalikKiloKontroluRepostory
    {
        GlutensizYasamDbContext context;
        public HaftalikKiloKontroluRepostory()
        {
            context = new GlutensizYasamDbContext();
        }

        public List<HaftalikKiloKontrolu> GetByKullaniciId(int kullaniciID)
        {
            return context.HaftalikKiloKontrolleri.Where(a => a.KullaniciId == kullaniciID).ToList();
        }

        public HaftalikKiloKontrolu GetByHaftalikKiloKontroluID(int haftalikKiloKontroluID)
        {
            return context.HaftalikKiloKontrolleri.Find(haftalikKiloKontroluID);
        }

        public bool Insert(HaftalikKiloKontrolu haftalikKiloKontrolu)
        {
            context.HaftalikKiloKontrolleri.Add(haftalikKiloKontrolu);
            return context.SaveChanges() > 0;
        }


    }
}
