using System.Collections.Generic;
using System.Linq;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;

namespace NetCoreSpaceApi.Repositories
{
    public class StarRepository : IStarRepository
    {
        private readonly ApplicationContext context;

        public StarRepository(ApplicationContext _context)
        {
            this.context = _context;
        }

        public List<Star> GetAll()
        {
            var resultData = context.Star.ToList();
            return resultData;
        }

        public Star GetId(int id)
        {
            var resultData = context.Star.ToList().Where(x => x.Id == id).FirstOrDefault();
            return resultData;
        }
    }
}
