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
    internal class BesinConfiguration: EntityTypeConfiguration<Besin>
    {
        public BesinConfiguration()
        {
            Property(a=>a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.BesinAdi).IsRequired().HasMaxLength(50);
            Property(a => a.Protein).IsRequired();
            Property(a => a.Karbonhidrat).IsRequired();
            Property(a => a.Yag).IsRequired();
            HasMany(a=>a.Tarifler).WithMany(b=>b.Besinler);
            HasMany(a => a.GunlukPlanlar).WithMany(b => b.Besinler);


        }
    }
}
