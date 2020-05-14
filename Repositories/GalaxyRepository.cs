using System.Collections.Generic;
using System.Linq;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;

namespace NetCoreSpaceApi.Repositories
{
    public class GalaxyRepository : IGalaxyRepository
    {
        private readonly ApplicationContext context;

        public GalaxyRepository(ApplicationContext _context)
        {
            this.context = _context;
        }

        public List<Galaxy> GetAll()
        {
            var resultData = context.Galaxy.ToList();
            return resultData;
        }

        public Galaxy GetId(int id)
        {
            var resultData = context.Galaxy.ToList().Where(x => x.Id == id).FirstOrDefault();
            return resultData;
        }
    }
}
