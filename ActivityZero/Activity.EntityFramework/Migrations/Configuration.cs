using System.Data.Entity.Migrations;
using Activity.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Activity.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Activity.EntityFramework.ActivityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Activity";
        }

        protected override void Seed(Activity.EntityFramework.ActivityDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
