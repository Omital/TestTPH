using TestTPH.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TestTPH.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TestTPHDbContext _context;

        public InitialHostDbBuilder(TestTPHDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
