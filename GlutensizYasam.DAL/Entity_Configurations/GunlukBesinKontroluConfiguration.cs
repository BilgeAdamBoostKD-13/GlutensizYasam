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
    internal class GunlukBesinKontroluConfiguration: EntityTypeConfiguration<GunlukBesinKontrolu>
    {
        public GunlukBesinKontroluConfiguration()
        {
            Property(a=>a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Tarih).HasColumnType("datetime2");


        }
    }
}
