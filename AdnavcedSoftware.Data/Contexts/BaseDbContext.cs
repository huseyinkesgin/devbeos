using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace AdnavcedSoftware.Data.Contexts
{
    public class BaseDbContext<TContext, Tconfigaration> : DbContext 
        where TContext : DbContext 
        where Tconfigaration : DbMigrationsConfiguration<TContext>, new()
    {
        private static string _nameOfConnectionString=typeof(TContext).Name;
        public BaseDbContext():base(_nameOfConnectionString) { }
        public BaseDbContext(string connectionString): base(connectionString) 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TContext, Tconfigaration>());
            _nameOfConnectionString = connectionString;
        }

    }
    
}
