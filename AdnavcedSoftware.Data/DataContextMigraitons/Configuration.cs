using AdnavcedSoftware.Data.Contexts;
using System.Data.Entity.Migrations;

namespace AdnavcedSoftware.Data.DataContextMigraitons
{
    public class Configuration: DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
