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

            //BESİNLER

            //Glutensiz Besinler

            //EtGrubu
            Besin Yumurta = new Besin() { BesinAdi = "Yumurta", Protein = 6.28, Karbonhidrat = 0.36, Yag = 4.76, AktifMi = false,Kalori=72 };
            context.Besinler.Add(Yumurta);
            Besin Alabalik = new Besin() { BesinAdi = "Alabalık", Protein = 36.6, Karbonhidrat = 0, Yag = 20, AktifMi = false, Kalori = 336 };
            context.Besinler.Add(Alabalik);
            Besin TavukKanat = new Besin() { BesinAdi = "Tavuk Kanat", Protein = 18, Karbonhidrat = 0, Yag = 13.98, AktifMi = false, Kalori = 198 };
            context.Besinler.Add(TavukKanat);
            Besin Hindi = new Besin() { BesinAdi = "Hindi Göğüs", Protein = 29.64, Karbonhidrat = 0, Yag = 1.08, AktifMi = false, Kalori=160 };
            context.Besinler.Add(Hindi);
            Besin Et = new Besin() { BesinAdi = "Kırmızı Et", Protein = 8.28, Karbonhidrat = 0, Yag = 3.67, AktifMi = false, Kalori = 60};
            context.Besinler.Add(Et);

            //TahılGrubu
            Besin BeyazPirinc = new Besin() { BesinAdi = "Beyaz Pirinç", Protein = 13.22, Karbonhidrat = 158.68, Yag = 1.16, AktifMi = false, Kalori = 720 };
            context.Besinler.Add(BeyazPirinc);
            Besin KaraBugday = new Besin() { BesinAdi = "Kara Buğday", Protein = 18.55, Karbonhidrat = 100, Yag = 4.76, AktifMi = false, Kalori = 480 };
            context.Besinler.Add(KaraBugday);

            //Baklagiller
            Besin Nohut = new Besin() { BesinAdi = "Nohut", Protein = 24.6, Karbonhidrat = 73.2, Yag = 5.7, AktifMi = false, Kalori = 432 };
            context.Besinler.Add(Nohut);
            Besin Bezelye = new Besin() { BesinAdi = "Bezelye", Protein = 16.26, Karbonhidrat = 43.3, Yag = 1.2, AktifMi = false, Kalori = 243 };
            context.Besinler.Add(Bezelye);
            Besin Mercimek = new Besin() { BesinAdi = "Mercimek", Protein = 43.88, Karbonhidrat = 71.3, Yag = 2.67, AktifMi = false, Kalori = 547 };
            context.Besinler.Add(Mercimek);
            Besin Fasulye = new Besin() { BesinAdi = "Fasulye", Protein = 34.8, Karbonhidrat = 47.07, Yag = 2.16, AktifMi = false, Kalori = 450 };
            context.Besinler.Add(Fasulye);

            //Yağ Grubu
            Besin ZeytinYag = new Besin() { BesinAdi = "Zeytin Yağ", Protein = 0, Karbonhidrat = 0, Yag = 4.5, AktifMi = false, Kalori = 40 };
            context.Besinler.Add(ZeytinYag);
            Besin AvokadoYag = new Besin() { BesinAdi = "Avokado Yağ", Protein = 0, Karbonhidrat = 0, Yag = 5, AktifMi = false, Kalori = 44 };
            context.Besinler.Add(AvokadoYag);

            //Meyveler
            Besin Ananas = new Besin() { BesinAdi = "Ananas", Protein = 0.43, Karbonhidrat = 10.50, Yag = 0.10, AktifMi = false, Kalori = 40 };
            context.Besinler.Add(Ananas);
            Besin Kayisi = new Besin() { BesinAdi = "Kayısı", Protein = 0.42, Karbonhidrat = 3.34, Yag = 0.12, AktifMi = false, Kalori = 14 };
            context.Besinler.Add(Kayisi);
            Besin Kavun = new Besin() { BesinAdi = "Kavun", Protein = 2, Karbonhidrat = 11.84, Yag = 0.18, AktifMi = false, Kalori = 180 };
            context.Besinler.Add(Kavun);
            Besin Erik = new Besin() { BesinAdi = "Erik", Protein = 0.70, Karbonhidrat = 11.42, Yag = 0.28, AktifMi = false, Kalori = 46 };
            context.Besinler.Add(Erik);

            //Sebzeler
            Besin Salatalik = new Besin() { BesinAdi = "Salatalık", Protein = 0.78, Karbonhidrat = 4.36, Yag = 0.13, AktifMi = false, Kalori = 18 };
            context.Besinler.Add(Salatalik);
            Besin Brokoli = new Besin() { BesinAdi = "Brokoli", Protein = 4.95, Karbonhidrat = 3.77, Yag = 0.30, AktifMi = false, Kalori = 150 };
            context.Besinler.Add(Brokoli);
            Besin Patates = new Besin() { BesinAdi = "Patates", Protein = 4.37, Karbonhidrat = 37.25, Yag = 0.19, AktifMi = false, Kalori = 164 };
            context.Besinler.Add(Patates);
            Besin Domates = new Besin() { BesinAdi = "Domates", Protein = 0.97, Karbonhidrat = 4.28, Yag = 0.22, AktifMi = false, Kalori = 20 };
            context.Besinler.Add(Domates);

            //Glutenli Besinler
            Besin BeyazEkmek = new Besin() { BesinAdi = "Beyaz Ekmek", Protein = 2.67, Karbonhidrat = 10.98, Yag = 0.54, AktifMi = true, Kalori = 60 };
            context.Besinler.Add(BeyazEkmek);
            Besin Makarna = new Besin() { BesinAdi = "Makarna", Protein = 5.22, Karbonhidrat = 27.53, Yag = 0.84, AktifMi = true, Kalori = 141 };
            context.Besinler.Add(Makarna);
            Besin Bulgur = new Besin() { BesinAdi = "Bulgur", Protein = 3.61, Karbonhidrat = 23.64, Yag = 4.4, AktifMi = true, Kalori = 488 };
            context.Besinler.Add(Bulgur);
            Besin Eriste = new Besin() { BesinAdi = "Erişte", Protein = 4.57, Karbonhidrat = 25.35, Yag = 13.6, AktifMi = true, Kalori = 244 };
            context.Besinler.Add(Eriste);
            Besin Simit = new Besin() { BesinAdi = "Simit", Protein = 2.34, Karbonhidrat = 48.93, Yag = 5.15, AktifMi = true, Kalori = 255 };
            context.Besinler.Add(Simit);
            Besin Cikolata = new Besin() { BesinAdi = "Cikolata", Protein = 0.22, Karbonhidrat = 2.9, Yag = 1.76, AktifMi = true, Kalori = 26 };
            context.Besinler.Add(Cikolata);
            Besin Sucuk = new Besin() { BesinAdi = "Sucuk", Protein = 7.12, Karbonhidrat = 2.57, Yag = 14.19, AktifMi = true, Kalori = 166 };
            context.Besinler.Add(Sucuk);
            Besin Krema = new Besin() { BesinAdi = "Krema", Protein = 6.6, Karbonhidrat = 9, Yag = 70, AktifMi = true, Kalori = 602 };
            context.Besinler.Add(Krema);
            Besin Viski = new Besin() { BesinAdi = "Viski", Protein = 0, Karbonhidrat = 0.06, Yag = 0, AktifMi = true, Kalori = 125 };
            context.Besinler.Add(Viski);
            Besin Irmik = new Besin() { BesinAdi = "İrmik", Protein = 1.27, Karbonhidrat = 7.28, Yag = 0.11, AktifMi = true, Kalori = 36 };
            context.Besinler.Add(Irmik);
            Besin Kek = new Besin() { BesinAdi = "Kek", Protein = 3.18, Karbonhidrat = 23.53, Yag = 6.54, AktifMi = true, Kalori = 172 };
            context.Besinler.Add(Kek);
            Besin Pogaca = new Besin() { BesinAdi = "Pogaca", Protein = 4.91, Karbonhidrat = 22.33, Yag = 14.74, AktifMi = true, Kalori = 416 };
            context.Besinler.Add(Pogaca);

            //YEMEK TARİFLERİ
            //Glutensiz Yemek Tarifleri
            Tarif GMuhallebi = new Tarif() { TarifAdi = "Glutensiz Muhallebi",TarifIcerigi= "1 kg süt\r\n2 yemek kaşığı glutensiz un\r\n1, 5 yemek kaşığı mısır nişastası\r\n6 yemek kaşığı toz şeker\r\n1 paket toz vanilin\r\n1 paket glutensiz bebe bisküvisi\r\nSüt, un, nişasta, şeker tencerede karıştırılarak kaynatılır.\r\nFokurdayınca altı kısılıp 2 dakika daha kaynatılmaya devam edilir.\r\nDaha sonra altı kapatılır içine vanilin atılıp karıştırılır.\r\nMuhallebi soğumaya bırakılır.\r\nBisküvi robotta çekilir. El yakmayacak kadar ılıyan muhallebi ve bisküvi sırasıyla bardaklara doldurulur üst", AktifMi = true };
            context.Tarifler.Add(GMuhallebi);

            Tarif GIslakKek = new Tarif() { TarifAdi = "Glutensiz Islak Kek", TarifIcerigi = "3 yumurta\r\n1 bardak şeker\r\nYarım bardak süt\r\nYarım bardak yağ\r\n3 yemek kaşığı kakao\r\n1 bardak glutensiz un\r\n1 paket vanilya\r\n1 paket kabartma tozu\r\nSosu için;\r\nYarım çay bardağı sıvı yağ\r\n1 su bardağı süt\r\n1 su bardağı şeker\r\n2 yemek kaşığı kakao\r\nİlk önce yumurtalarımızı karıştırma kabına kıralım. Sonra şekerimizi de ekleyip köpürene kadar çırpalım. Daha sonra sütümüzü ve yağımızı da ekleyip iki dakika çırpalım. Bir bardak unumuzun üstüne kabartma tozu vanilya ve kakaoyu da ekleyip çırpmaya devam edelim. Yağlanmış borcama koyup 180 derecede 35 dakika pişirelim. Kek pişmeye yakınken kekin sosunu da hazırlayalım. Tencereye sütü yağı şekeri ve kakaoyu koyup kaynatalım. Pişen keki dilimleyelim. Sosu üzerine dökelim. Kek ve sos sıcak olmalı.\r\n\r\n", AktifMi = true };
            context.Tarifler.Add(GIslakKek);

            Tarif GMEkmek = new Tarif() { TarifAdi = "Glutensiz ve Mayasız Ekmek", TarifIcerigi = "1 su bardağı süt veya su\r\n1 yumurta\r\n1/4 (çeyrek) su bardağı ya da yarım çay bardağı zeytinyağı\r\n1/4 su bardağı ya da yarım çay bardağı pekmez\r\n1 tatlı kaşığı tuz.\r\n1 su bardağı mısır unu\r\n1 su bardağı karabuğday unu\r\n1 paket kabartma tozu\r\n1 tatlı kaşığı soda\r\nİlk olarak sütü ısıtıp mısır unu ile karıştıralım.\r\nAyrı bir büyük kap içerisinde yumurta, pekmez ve zeytinyağını çırpalım.\r\nÜzerine sütlü mısır ununu ilave edelim.\r\nBir taraftan çırpmaya devam ederken diğer taraftan da karabuğday ununu, kabartma tozunu, tuz ve sodayı ilave edelim.\r\nKek hamurundan biraz daha kıvamlı bir hamur elde edelim ve yağlanmış ve unlanmış kalıba dökelim.\r\nÖnceden ısıtılmış 180 derece fırında 35 dakika kadar pişirelim. Afiyet olsun…", AktifMi = true };
            context.Tarifler.Add(GMEkmek);

            Tarif GMercimekKofte = new Tarif() { TarifAdi = "Glutensiz Mercimekli Köfte", TarifIcerigi = "1 su bardağı kırmızı mercimek\r\n1 su bardağı karabuğday unu\r\n3 su bardağı su\r\n1 tatlı kaşığı biber salçası\r\n1 tatlı kaşığı domates salçası\r\n1 kuru soğan\r\n4-5 taze soğanın yeşil kısmı\r\nYarım demet maydanoz\r\n1 limon suyu\r\nZeytinyağı\r\nPul biber\r\nKişniş\r\nTuz\r\nMercimeği yıkayın ve suyla pişirin. Suyunu çekince karabuğday ununu ve tuz ekleyin tencerenin ağzını kapatın. Bu arada ayrı bir kapta zeytin yağında kuru soğanı kavurun ve biber salçası ile domates salçasını pişirin.\r\n\r\nTaze soğanın yeşil kısmını ve maydanozu ince ince doğrayın. Mercimeği karıştırma kabına alın. Baharatlarla iyice yoğurun ( burada karışımın merhem gibi olduğunu göreceksiniz). Sosu da yedirin ve yeşillikleri limonu isterseniz nar eksisini de ekleyin ve sıkım sıkım yapın servis edin.", AktifMi = true };
            context.Tarifler.Add(GMercimekKofte);

            context.SaveChanges();
        }
        
    }
}
