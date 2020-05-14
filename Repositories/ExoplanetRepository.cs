using System.Collections.Generic;
using System.Linq;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;

namespace NetCoreSpaceApi.Repositories
{
    public class ExoplanetRepository : IExoplanetRepository
    {
        private readonly ApplicationContext context;

        public ExoplanetRepository(ApplicationContext _context)
        {
            this.context = _context;
        }

        public List<Exoplanet> GetAll()
        {
            var resultData = context.Exoplanet.ToList();
            return resultData;
        }

        public Exoplanet GetId(int id)
        {
            var resultData = context.Exoplanet.ToList().Where(x => x.Id == id).FirstOrDefault();
            return resultData;
        }
    }
}
