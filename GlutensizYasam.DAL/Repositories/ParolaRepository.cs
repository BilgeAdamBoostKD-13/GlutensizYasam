using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Repositories
{
    public class ParolaRepository
    {
        GlutensizYasamDbContext context;
        public ParolaRepository()
        {
            context = new GlutensizYasamDbContext();
        }


        public bool Insert(Parola parola)
        {
            context.Parolalar.Add(parola);
            return context.SaveChanges() > 0;
        }
        public Parola GetParolaID(int kullaniciID)
        {
            return context.Parolalar.Where(a => a.KullaniciId == kullaniciID).FirstOrDefault();
        }

        public Parola AktifParolayiVer(int kullaniciID)
        {
            return context.Parolalar.Where(a => a.KullaniciId == kullaniciID ).FirstOrDefault();
        }

        
    }
}
