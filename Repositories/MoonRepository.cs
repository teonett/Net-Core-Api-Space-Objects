using System.Collections.Generic;
using System.Linq;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;

namespace NetCoreSpaceApi.Repositories
{
    public class MoonRepository : IMoonRepository
    {
        private readonly ApplicationContext context;

        public MoonRepository(ApplicationContext _context)
        {
            this.context = _context;
        }

        public List<Moon> GetAll()
        {
            var resultData = context.Moon.ToList();
            return resultData;
        }

        public Moon GetId(int id)
        {
            var resultData = context.Moon.ToList().Where(x => x.Id == id).FirstOrDefault();
            return resultData;
        }
    }
}
