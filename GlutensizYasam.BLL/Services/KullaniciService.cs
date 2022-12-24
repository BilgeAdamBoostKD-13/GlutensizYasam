using GlutensizYasam.DAL;
using GlutensizYasam.DAL.Repositories;
using GlutensizYasam.Model.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.BLL.Services
{
    public class KullaniciService
    {
       // GlutensizYasamDbContext db;
        KullaniciRepository kullaniciRepository;

        public KullaniciService()
        {
            kullaniciRepository = new KullaniciRepository();
           // db = new GlutensizYasamDbContext();
        }

        public bool Insert (Kullanici kullanici) // kullanıcı kaydetme 
        {
            if (string.IsNullOrWhiteSpace(kullanici.Isim) || string.IsNullOrWhiteSpace(kullanici.SoyIsim)) //isim soyisim kontrolü 
            {
                throw new Exception("İsim ya da Soyisim bilgisi eksik");
            }

            Parola ilkparola = kullanici.Parolalar.FirstOrDefault(); // şifre girdi mi girmedi mi diye bakma
            if (ilkparola == null)
            {
                throw new Exception("Parola giriniz");
            }

            //kullanici.OlusturulmaTarihi = DateTime.Now;
            //kullanici.Parolalar.FirstOrDefault().OlusturulmaTarihi = DateTime.Now;
            kullanici.KullaniciTipi = Model.Enums.KullaniciTipi.Standart; //kullanıcı tipi verme
            return kullaniciRepository.Insert(kullanici); //repoya kullanıcıyı atıp oradaki insert metodunu kullanarak kullanıcıyı db ye ekleme.
        }

        public Kullanici GirisKontrolu (string mail , string parola)
        {
            if (string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(parola)) throw new Exception("Kullanıcı Adı ya da parola girişi yapmadınız.");

            return kullaniciRepository.CheckLogin(mail, parola);
            
        }

        void KullaniciIDKontrolu(Kullanici kullanici)
        {
            if (kullanici.ID <= 0 )
            {
                throw new Exception("User Id Boş Olamaz");
            }
        }

        
        public bool EmailKontrolu(string kullaniciEmail)
        {
            bool check = kullaniciRepository.EmailKontrolEt(kullaniciEmail);
            return check;
           
        }

        public int KullaniciIdGetir(string email)
        {
            int Id = kullaniciRepository.KullaniciIdGetir(email);
            return Id;
        }


    }
}
