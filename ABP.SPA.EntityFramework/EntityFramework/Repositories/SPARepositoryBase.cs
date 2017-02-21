using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABP.SPA.EntityFramework.Repositories
{
    public abstract class SPARepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SPADbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SPARepositoryBase(IDbContextProvider<SPADbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SPARepositoryBase<TEntity> : SPARepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SPARepositoryBase(IDbContextProvider<SPADbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
