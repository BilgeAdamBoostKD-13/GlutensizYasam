using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL.Entity_Configurations
{
    internal class GunlukPlanConfiguration : EntityTypeConfiguration<GunlukPlan>
    {
        public GunlukPlanConfiguration()
        {
            Property(a=>a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a=>a.Tarih).IsRequired();
            Property(a => a.Tarih).HasColumnType("datetime2");
            HasMany(a => a.Tarifler).WithMany(b => b.GunlukPlanlar);
            
        }
    }
}
