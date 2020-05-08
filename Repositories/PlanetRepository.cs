using System.Collections.Generic;
using System.Linq;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Base;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;

namespace NetCoreSpaceApi.Repositories
{
    public class PlanetRepository : BaseRepository<Planet>, IPlanetRepository
    {
        public PlanetRepository(ApplicationContext context) : base(context)
        {
        }

        public List<Planet> GetAll()
        {
            var resultData = dbSet.ToList();
            return resultData;
        }

        public Planet GetId(int id)
        {
            var resultData = dbSet.ToList().Where(x => x.Id == id).FirstOrDefault();
            return resultData;
        }
    }
}
