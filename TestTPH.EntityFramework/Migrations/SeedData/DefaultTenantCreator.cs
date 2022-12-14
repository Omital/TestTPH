using System.Linq;
using TestTPH.EntityFramework;
using TestTPH.MultiTenancy;

namespace TestTPH.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TestTPHDbContext _context;

        public DefaultTenantCreator(TestTPHDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
