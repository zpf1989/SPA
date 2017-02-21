using System.Data.Entity.Migrations;

namespace ABP.SPA.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SPA.EntityFramework.SPADbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SPA";
        }

        protected override void Seed(SPA.EntityFramework.SPADbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
