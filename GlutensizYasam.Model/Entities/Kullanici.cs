﻿using GlutensizYasam.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public class Kullanici : BaseEntity
    {
        public Kullanici()
        {
            Parolalar = new HashSet<Parola>();
            HaftalikKiloKontrolleri = new HashSet<HaftalikKiloKontrolu>();
            GunlukPlanlar = new HashSet<GunlukPlan>();

        }
        private string email;
        public string EMail
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Contains("@")) email = value;
                else throw new Exception("Lütfen mail adresinizi doğru giriniz.");
            }
        }
        private string isim;
        public string Isim // giriş ekranında sadece harf girişi yaptırmamız gerekiyor
        {
            get
            {
                return isim;
            }
            set
            {
                if (value.Length >= 2) isim = value;
                else throw new Exception("Ad en az 2 karakterli olmalıdır.");

            }
        }
        private string soyisim;
        public string SoyIsim // giriş ekranında sadece harf girişi yaptırmamız gerekiyor
        {
            get
            {
                return soyisim;
            }

            set
            {
                if (value.Length >= 2) soyisim = value;
                else
                {
                    throw new Exception("Soyad en az 2 karakterli olmalıdır.");
                }

            }
        }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        private double kilo;
        public double Kilo // giriş ekranında sadece sayı girişi yaptırmamız gerekiyor. 
        {
            get
            {
                return kilo;
            }
            set
            {                
                if (value < 0) throw new Exception("Lütfen 0 dan küçük bir sayı girmeyiniz.!");
                else if (value >= 600) throw new Exception("Çok büyük bir sayı girdiniz.!");
                else kilo = value;
            }
        }
        public double GunlukKaloriIhtiyaci
        { 
            get
            {
                if (Cinsiyet == Model.Enums.Cinsiyet.Erkek)
                {
                    if (SporBilgisi == Model.Enums.SporTipi.SporYok)
                    {
                      return (((10 * kilo) + (6.25 * Boy) - (5 * (DateTime.Now.Year - DogumTarihi.Year)) + 5) * 1.2);
                    }
                   else if (SporBilgisi == Model.Enums.SporTipi.OrtaSeviyeli)
                    {
                        return (((10 * kilo) + (6.25 * Boy) - (5 * (DateTime.Now.Year - DogumTarihi.Year)) + 5) * 1.55);
                    }
                    else
                    {
                        return (((10 * kilo) + (6.25 * Boy) - (5 * (DateTime.Now.Year - DogumTarihi.Year)) + 5) * 1.72);
                    }
                }
                else
                {
                    if (SporBilgisi == Model.Enums.SporTipi.SporYok)
                    {
                        return (((10 * kilo) + (6.25 * Boy) - (5 * (DateTime.Now.Year - DogumTarihi.Year)) - 161) * 1.2);
                    }
                    else if(SporBilgisi == Model.Enums.SporTipi.OrtaSeviyeli)
                    {
                        return (((10 * kilo) + (6.25 * Boy) - (5 * (DateTime.Now.Year - DogumTarihi.Year)) - 161) * 1.55);
                    }
                    else
                    {
                        return (((10 * kilo) + (6.25 * Boy) - (5 * (DateTime.Now.Year - DogumTarihi.Year)) - 161) * 1.72);
                    }
             
                }
            }
        }
        public double Boy { get; set; }  // giriş ekranında sadece sayı girişi yaptırmamız gerekiyor. 
        public int HedefKilo { get; set; }  // giriş ekranında sadece sayı girişi yaptırmamız gerekiyor. 
        public KullaniciTipi KullaniciTipi { get; set; }
        public SporTipi SporBilgisi { get; set; }

        public virtual ICollection<Parola>Parolalar { get; set; }
        public virtual ICollection<HaftalikKiloKontrolu>HaftalikKiloKontrolleri { get; set; }
        public virtual ICollection<GunlukPlan>GunlukPlanlar { get; set; }
    }
}
