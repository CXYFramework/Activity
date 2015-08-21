using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Activity.EntityFramework.Repositories
{
    public abstract class ActivityRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ActivityDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ActivityRepositoryBase(IDbContextProvider<ActivityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ActivityRepositoryBase<TEntity> : ActivityRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ActivityRepositoryBase(IDbContextProvider<ActivityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
