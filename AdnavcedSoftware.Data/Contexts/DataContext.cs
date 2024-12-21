using AdavancedSoftware.Model.Entities;
using AdnavcedSoftware.Data.DataContextMigraitons;
 
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace AdnavcedSoftware.Data.Contexts
{
    public class DataContext : BaseDbContext<DataContext, Configuration >
    {

        public DataContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DataContext(string connectionString) : base(connectionString) 
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Ofis> Ofis { get; set; }
        public DbSet<Sube> Sube { get; set; }
        public DbSet<Donem> Donem { get; set; }
        public DbSet<Filtre> Filtre { get; set; }
        public DbSet<MusteriBilgi> MusteriBilgi { get; set; }
        public DbSet<IptalNedeni> IptalNedeni { get; set; }
        public DbSet<PortfoyTipi> PortfoyTipi { get; set; }
        public DbSet<TapuTipi> TapuTipi { get; set; }
        public DbSet<ImarBilgisi> ImarBilgisi { get; set; }
        public DbSet<Emsal> Emsal { get; set; }
        public DbSet<Gabari> Gabari { get; set; }
        public DbSet<Isitma> Isitma { get; set; }
        public DbSet<MusteriGrup> MusteriGrup { get; set; }
        public DbSet<Departman> Departman { get; set; }
        public DbSet<Unvan> Unvan { get; set; }
        public DbSet<Altyapi> Altyapi { get; set; }
        public DbSet<OzelKod> OzelKod { get; set; }
        public DbSet<Kasa> Kasa { get; set; }

    }


}