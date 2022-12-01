using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TestTPH.EntityFramework.Repositories
{
    public abstract class TestTPHRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TestTPHDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TestTPHRepositoryBase(IDbContextProvider<TestTPHDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TestTPHRepositoryBase<TEntity> : TestTPHRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TestTPHRepositoryBase(IDbContextProvider<TestTPHDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
