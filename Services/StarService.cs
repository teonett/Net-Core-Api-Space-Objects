using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Services
{
    public class StarService : IStarService
    {
        private readonly IStarRepository starRepository;

        public StarService(IStarRepository star)
        {
            this.starRepository = star;
        }

        public List<Star> GetAll()
        {
            return starRepository.GetAll();
        }

        public Star GetId(int id)
        {
            return starRepository.GetId(id);
        }
    }
}
