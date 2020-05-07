using Microsoft.EntityFrameworkCore;
using NetCoreSpaceApi.Data;

namespace NetCoreSpaceApi.Repositories.Base
{
    public abstract class BaseRepository<T> where T : EntityBase
    {
        protected readonly ApplicationContext contexto;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
