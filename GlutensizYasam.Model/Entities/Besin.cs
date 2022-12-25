using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public class Besin : BaseEntity
    {
        public Besin()
        {
            Tarifler = new HashSet<Tarif>();
            GunlukPlanlar = new HashSet<GunlukPlan>();
        }
        public string BesinAdi { get; set; }

        public double Kalori 
        {
            get
            {
                return (4 * Protein + 4 * Karbonhidrat + 9 * Yag);
            }

        }
        public double Protein { get; set; } //formda sadece sayı girişi olacak
        public double Karbonhidrat { get; set; } //formda sadece sayı girişi olacak
        public double Yag { get; set; } //formda sadece sayı girişi olacak
        public bool AktifMi { get; set; }
        public virtual ICollection<Tarif>Tarifler { get; set; }
        public virtual ICollection<GunlukPlan>GunlukPlanlar { get; set; }


        

    }
}
