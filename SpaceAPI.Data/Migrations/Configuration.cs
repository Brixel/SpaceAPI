using System.Data.Entity.Migrations;
using SpaceAPI.Data.Contexts;
using SpaceAPI.Data.Models.API;
using SpaceAPI.Models.API;

namespace SpaceAPI.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            // 
            context.SaveChanges();

        }
    }
}
