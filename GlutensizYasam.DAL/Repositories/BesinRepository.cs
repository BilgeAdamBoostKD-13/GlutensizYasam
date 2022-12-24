using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Repositories
{
    public class BesinRepository
    {
        GlutensizYasamDbContext context;
        public BesinRepository()
        {
            context = new GlutensizYasamDbContext();
        }

        public Besin GetByBesinId(int besinID)
        {
            return context.Besinler.Find(besinID);
        }

        public bool Insert(Besin besin)
        {
            context.Besinler.Add(besin);
            return context.SaveChanges() > 0;
        }

        public bool Update(Besin besin)
        {
            Besin updateBesin = GetByBesinId(besin.ID);
            updateBesin.Protein = besin.Protein;
            updateBesin.Karbonhidrat = besin.Karbonhidrat;
            updateBesin.Yag = besin.Yag;
            return context.SaveChanges() > 0;
        }

        public bool Delete(Besin besin)
        {
            Besin deletedBesin = GetByBesinId(besin.ID);
            deletedBesin.AktifMi = false;
            return context.SaveChanges() > 0;
        }

        public int BesinBul(string arananBesin)
        {
            var id = context.Besinler.Where(a => a.BesinAdi == arananBesin).Select(a => a.ID);
            int besinid = id.First();
            return besinid;
             
        }
        
    }
}
