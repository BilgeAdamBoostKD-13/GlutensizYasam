using GlutensizYasam.Model.Enums;
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
        public string EMail { get; set; }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }        
        public int Kilo { get; set; }
        public int Boy { get; set; }
        public int HedefKilo { get; set; }
        public KullaniciTipi KullaniciTipi { get; set; }
        public SporTipi SporBilgisi { get; set; }

        public virtual ICollection<Parola>Parolalar { get; set; }
        public virtual ICollection<HaftalikKiloKontrolu>HaftalikKiloKontrolleri { get; set; }
        public virtual ICollection<GunlukPlan>GunlukPlanlar { get; set; }
    }
}
