using GlutensizYasam.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
            GunlukBesinKontrolu = new HashSet<GunlukBesinKontrolu>();
        }
        public DateTime Tarih { get; set; }
        public Ogun Ogun { get; set; }
        public int KullaniciId { get; set; }
        public virtual ICollection<Besin>Besinler { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<GunlukBesinKontrolu> GunlukBesinKontrolu { get; set; }    

    }
}
 