using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.Model.Entities
{
    public class BesinGunlukPlan:BaseEntity
    {
        public int BesinId { get; set; }
        public int GunlukPlanId { get; set; }

        public virtual Besin besin { get; set; }
        public virtual GunlukPlan GunlukPlan { get; set; }

    }
}
