﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public class GunlukPlan : BaseEntity
    {
        public GunlukPlan()
        {
            Besinler = new HashSet<Besin>();
            Tarifler = new HashSet<Tarif>();
            GunlukBesinKontrolleri = new HashSet<GunlukBesinKontrolu>();
        }
        public string Kahvalti { get; set; }
        public string OgleYemegi { get; set; }
        public string AraOgun { get; set; }
        public string AksamYemegi { get; set; }
        public int KullaniciId { get; set; }
        
        public virtual ICollection<Besin>Besinler { get; set; }
        public virtual ICollection<Tarif> Tarifler { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public virtual ICollection<GunlukBesinKontrolu> GunlukBesinKontrolleri { get; set; }

    }
}
