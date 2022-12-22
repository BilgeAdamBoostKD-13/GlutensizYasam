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
    internal class KullaniciConfiguration : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciConfiguration()
        {
            Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.EMail).IsRequired();
            Property(a => a.DogumTarihi).HasColumnType("datetime2");

            HasMany(a => a.Parolalar).WithRequired(b => b.Kullanici).HasForeignKey(c => c.KullaniciId);
            HasMany(a => a.HaftalikKiloKontrolleri).WithRequired(b => b.Kullanici).HasForeignKey(c => c.KullaniciId);
            HasMany(a => a.GunlukPlanlar).WithRequired(b => b.Kullanici).HasForeignKey(c => c.KullaniciId);
        }
    }
}
