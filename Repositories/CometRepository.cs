using System.Collections.Generic;
using System.Linq;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;

namespace NetCoreSpaceApi.Repositories
{
    public class CometRepository : ICometRepository
    {
        private readonly ApplicationContext context;

        public CometRepository(ApplicationContext _context)
        {
            this.context = _context;
        }

        public List<Comet> GetAll()
        {
            var resultData = context.Comet.ToList();
            return resultData;
        }

        public Comet GetId(int id)
        {
            var resultData = context.Comet.ToList().Where(x => x.Id == id).FirstOrDefault();
            return resultData;
        }
    }
}
