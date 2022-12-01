using Abp.DynamicEntityProperties;
using Abp.Zero.EntityFramework;
using System.Data.Common;
using System.Data.Entity;
using TestTPH.Authorization.Roles;
using TestTPH.Authorization.Users;
using TestTPH.MultiTenancy;
using TestTPH.Peopels;

namespace TestTPH.EntityFramework
{
    public class TestTPHDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public IDbSet<Person> Peopels { get; set; }

        public IDbSet<PersonExtraDetail> PersonExtraDetails { get; set; }

        public TestTPHDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TestTPHDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TestTPHDbContext since ABP automatically handles it.
         */
        public TestTPHDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TestTPHDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public TestTPHDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Person>().HasOptional(j => j.ExtraDetail).WithRequired(j => j.Person);

            modelBuilder.Entity<Person>()
               .HasOptional(p => p.ExtraDetail)
               .WithRequired(p => p.Person)
               .WillCascadeOnDelete(true);


            modelBuilder.Entity<DynamicProperty>().Property(p => p.PropertyName).HasMaxLength(250);
            modelBuilder.Entity<DynamicEntityProperty>().Property(p => p.EntityFullName).HasMaxLength(250);
        }
    }
}
