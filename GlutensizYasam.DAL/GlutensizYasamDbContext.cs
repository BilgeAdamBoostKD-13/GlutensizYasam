using GlutensizYasam.DAL.Entity_Configurations;
using GlutensizYasam.DAL.Strategy;
using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlutensizYasam.DAL
{
    public class GlutensizYasamDbContext : DbContext
    {

        public GlutensizYasamDbContext():base("Data Source=.;Initial Catalog=GlutensizYasamDB;Integrated Security=true;")
        {
            Database.SetInitializer(new GlutensizYasamStrategy());
        }

        public DbSet<Besin> Besinler { get; set; }
        public DbSet<GunlukBesinKontrolu> gunlukBesinKontrolleri { get; set; }
        public DbSet<GunlukPlan> GunlukPlanlar { get; set; }
        public DbSet<HaftalikKiloKontrolu> HaftalikKiloKontrolleri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Parola> Parolalar { get; set; }
        public DbSet<Tarif> Tarifler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BesinConfiguration());
            modelBuilder.Configurations.Add(new GunlukBesinKontroluConfiguration());
            modelBuilder.Configurations.Add(new GunlukPlanConfiguration());
            modelBuilder.Configurations.Add(new HaftalıkKiloKontroluConfiguration());
            modelBuilder.Configurations.Add(new KullaniciConfiguration());
            modelBuilder.Configurations.Add(new ParolaConfiguration());
            modelBuilder.Configurations.Add(new TarifConfiguration());
        }
    }
}
