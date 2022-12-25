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
            //new Kullanici()
            //{
            //    EMail = "colyak@",
            //    Isim = "bmk",
            //    SoyIsim = "bmk",
            //    KullaniciTipi = KullaniciTipi.Standart
            //};
           
            kullanici.Parolalar.Add(new Parola()
            {
                UserPassword = "adminadmin"
            });

            //kullanici.Parolalar.Add(new Parola()
            //{
            //    UserPassword = "a"

            //});
            context.Kullanicilar.Add(kullanici);
            

            Besin besin =
                new Besin() { BesinAdi = "Yumurta", Protein = 6.28, Karbonhidrat = 0.36, Yag = 4.76, AktifMi = false };
                new Besin() { BesinAdi = "Beyaz Pirinç", Protein = 13.22, Karbonhidrat = 158.68, Yag = 1.16, AktifMi = false };
                new Besin() { BesinAdi = "Nohut", Protein = 24.6, Karbonhidrat = 73.2, Yag = 5.7, AktifMi = false };
            context.Besinler.Add(besin);
            context.SaveChanges();

        }
        
    }
}
