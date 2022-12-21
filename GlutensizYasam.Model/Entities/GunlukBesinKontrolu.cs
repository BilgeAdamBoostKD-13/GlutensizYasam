using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public class GunlukBesinKontrolu : BaseEntity
    {
        public GunlukBesinKontrolu()
        {
            GunlukPlanlar = new HashSet<GunlukPlan>();
        }
        public DateTime Tarih { get; set; }
        public int GunlukAlinanKalori { get; set; }
        public int GunlukIcilenSu { get; set; }
        public virtual ICollection<GunlukPlan> GunlukPlanlar { get; set; }


    }
}
