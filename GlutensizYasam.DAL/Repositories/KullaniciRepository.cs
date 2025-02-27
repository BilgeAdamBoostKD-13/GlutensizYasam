﻿using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Repositories
{
    public class KullaniciRepository
    {
        GlutensizYasamDbContext context;
        ParolaRepository parolaRepository;

        public KullaniciRepository()
        {
            context = new GlutensizYasamDbContext();
            parolaRepository = new ParolaRepository();
        }

        public bool Insert(Kullanici kullanici)
        {
            
            
            context.Kullanicilar.Add(kullanici);
            return context.SaveChanges() > 0;
           
        }

        public Kullanici CheckLogin(string email, string parola)
        {
            Kullanici kullanici = context.Kullanicilar.Where(a => a.EMail == email).SingleOrDefault();
            if (kullanici != null)
            {
                Parola kullaniciParolasi = parolaRepository.AktifParolayiVer(kullanici.ID);
                if (kullaniciParolasi != null && kullaniciParolasi.UserPassword == parola)
                {
                    return kullanici;
                }
            }
            return null;
        }

        public Kullanici GetKullaniciId(int kullaniciID)
        {
            return context.Kullanicilar.Where(a => a.ID == kullaniciID).FirstOrDefault();
        }

        public bool EmailKontrolEt(string email)
        {
            Kullanici kullanici = new Kullanici();
            List<Kullanici> kullaniciList = context.Kullanicilar.ToList();

            foreach (var item in kullaniciList)
            {
                if (item.EMail == email)
                {
                    return true;
                }
            }
            return false;
        }

        public int KullaniciIdGetir(string mail)
        {
            var index = context.Kullanicilar.Where(x => x.EMail == mail).Select(a => a.ID).ToList();
            int id = index.First();
            return id;
        }

        public bool Update(Kullanici kullanici)
        {
            Kullanici updateKullanici = GetKullaniciId(kullanici.ID);
            updateKullanici.Boy = kullanici.Boy;
            updateKullanici.HedefKilo = kullanici.HedefKilo;
            return context.SaveChanges() > 0;
        }
    }

    
}
