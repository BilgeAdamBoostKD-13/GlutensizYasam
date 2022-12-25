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
            
            //Glutensiz Besinler
            //EtGrubu
            Besin Yumurta = new Besin() { BesinAdi = "Yumurta", Protein = 6.28, Karbonhidrat = 0.36, Yag = 4.76, AktifMi = false };
            context.Besinler.Add(Yumurta);
            Besin Alabalik = new Besin() { BesinAdi = "Alabalık", Protein = 36.6, Karbonhidrat = 0, Yag = 20, AktifMi = false };
            context.Besinler.Add(Alabalik);
            Besin TavukKanat = new Besin() { BesinAdi = "Tavuk Kanat", Protein = 18, Karbonhidrat = 0, Yag = 13.98, AktifMi = false };
            context.Besinler.Add(TavukKanat);
            Besin Hindi = new Besin() { BesinAdi = "Hindi Göğüs", Protein = 29.64, Karbonhidrat = 0, Yag = 1.08, AktifMi = false };
            context.Besinler.Add(Hindi);
            Besin Et = new Besin() { BesinAdi = "Kırmızı Et", Protein = 8.28, Karbonhidrat = 0, Yag = 3.67, AktifMi = false };
            context.Besinler.Add(Et);
            //TahılGrubu
            Besin BeyazPirinc = new Besin() { BesinAdi = "Beyaz Pirinç", Protein = 13.22, Karbonhidrat = 158.68, Yag = 1.16, AktifMi = false };
            context.Besinler.Add(BeyazPirinc);
            Besin KaraBugday = new Besin() { BesinAdi = "Kara Buğday", Protein = 18.55, Karbonhidrat = 100, Yag = 4.76, AktifMi = false };
            context.Besinler.Add(KaraBugday);

            //Baklagiller
            Besin Nohut = new Besin() { BesinAdi = "Nohut", Protein = 24.6, Karbonhidrat = 73.2, Yag = 5.7, AktifMi = false };
            context.Besinler.Add(Nohut);

        }
        
    }
}
