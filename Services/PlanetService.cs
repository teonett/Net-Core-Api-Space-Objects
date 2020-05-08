using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository planetRepository; 

        public PlanetService(IPlanetRepository _planetRepository)
        {
            this.planetRepository = _planetRepository;
        }

        public List<Planet> GetAll()
        {
            var resultData = planetRepository.GetAll();
            return resultData;
        }

        public Planet GetId(int id)
        {
            var resultData = planetRepository.GetId(id);
            return resultData;
        }
    }
}
