using GlutensizYasam.Model.Entities;
using GlutensizYasam.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Strategy
{
    internal class GlutensizYasamStrategy : CreateDatabaseIfNotExists<GlutensizYasamDbContext>
    {
        protected override void Seed(GlutensizYasamDbContext context)
        {
            Kullanici kullanici = new Kullanici()
            {
                EMail = "admin@glutensizyasam.com",
                Isim = "admin",
                SoyIsim = "admin",
                KullaniciTipi = KullaniciTipi.Admin

            };
           
            kullanici.Parolalar.Add(new Parola()
            {
                UserPassword = "adminadmin"
            });
            context.Kullanicilar.Add(kullanici);
            context.SaveChanges();
           
        }
        
    }
}
