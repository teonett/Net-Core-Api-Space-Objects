using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Services
{
    public class GalaxyService : IGalaxyService
    {
        private readonly IGalaxyRepository galaxyRepository;

        public GalaxyService(IGalaxyRepository galaxy)
        {
            this.galaxyRepository = galaxy;
        }

        public List<Galaxy> GetAll()
        {
            return galaxyRepository.GetAll();
        }

        public Galaxy GetId(int id)
        {
            return galaxyRepository.GetId(id);
        }
    }
}
