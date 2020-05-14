using System.Collections.Generic;
using System.Linq;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;

namespace NetCoreSpaceApi.Repositories
{
    public class ConstelationRepository : IConstelationRepository
    {
        private readonly ApplicationContext context;

        public ConstelationRepository(ApplicationContext _context)
        {
            this.context = _context;
        }

        public List<Constelation> GetAll()
        {
            var resultData = context.Constelation.ToList();
            return resultData;
        }

        public Constelation GetId(int id)
        {
            var resultData = context.Constelation.ToList().Where(x => x.Id == id).FirstOrDefault();
            return resultData;
        }
    }
}
