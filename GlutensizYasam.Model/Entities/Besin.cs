using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            BesinGunlukPlanlar = new HashSet<BesinGunlukPlan>();
        }
        public string BesinAdi { get; set; }
       
        public double Kalori { get; set; }

        public double Protein { get; set; } //formda sadece sayı girişi olacak
        public double Karbonhidrat { get; set; } //formda sadece sayı girişi olacak
        public double Yag { get; set; } //formda sadece sayı girişi olacak
        public bool AktifMi { get; set; }
        public virtual ICollection<Tarif>Tarifler { get; set; }
        public virtual ICollection<BesinGunlukPlan> BesinGunlukPlanlar { get; set; }


        

    }
}
