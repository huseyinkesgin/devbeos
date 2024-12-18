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
       public DbSet<KargoFirmasi> KargoFirmasi { get; set; }
       public DbSet<Ofis> Ofis { get; set; }
       public DbSet<Filtre> Filtre { get; set; }

    }


}