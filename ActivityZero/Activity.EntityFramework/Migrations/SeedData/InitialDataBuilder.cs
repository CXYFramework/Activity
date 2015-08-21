using Activity.EntityFramework;

namespace Activity.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly ActivityDbContext _context;

        public InitialDataBuilder(ActivityDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new MenuBuilder(_context).Build();
        }
    }
}
