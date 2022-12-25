using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Entity_Configurations
{
    internal class BesinGunlukPlanConfiguration: EntityTypeConfiguration<BesinGunlukPlan>
    {
        public BesinGunlukPlanConfiguration()
        {
            HasRequired(a => a.GunlukPlan).WithMany(b => b.BesinGunlukPlanlar).HasForeignKey(c=>c.GunlukPlanId);
            HasRequired(a => a.besin).WithMany(b => b.BesinGunlukPlanlar).HasForeignKey(c => c.BesinId);
        }
    }
}
