using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Repositories
{
    public class TarifRepository
    {
        GlutensizYasamDbContext context;

        public TarifRepository()
        {
            context = new GlutensizYasamDbContext();
        }

        public Tarif GetByTarifId(int tarifID)
        {
            return context.Tarifler.Find(tarifID);
        }

        public bool Insert(Tarif tarif)
        {
            context.Tarifler.Add(tarif);
            return context.SaveChanges() > 0;
        }

        public bool Update(Tarif tarif)
        {
            Tarif updateTarif = GetByTarifId(tarif.ID);
            updateTarif.TarifAdi = tarif.TarifAdi;
            updateTarif.TarifIcerigi = tarif.TarifIcerigi;
            return context.SaveChanges() > 0;
        }

        public bool Delete(Tarif tarif)
        {
            Tarif deletedTarif = GetByTarifId(tarif.ID);
            deletedTarif.AktifMi = false;
            return context.SaveChanges() > 0;
        }

        public void ActivateTarif(Tarif tarif)
        {
            Tarif activatedTarif = GetByTarifId(tarif.ID);
            activatedTarif.AktifMi = true;
            context.SaveChanges();
        }

        public List<Tarif> GetPassiveTarifler()
        {
            return context.Tarifler.Where(a => !a.AktifMi).ToList();
        }
    }
}
