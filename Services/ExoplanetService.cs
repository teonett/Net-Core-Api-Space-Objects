using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Services
{
    public class ExoplanetService : IExoplanetService
    {
        private readonly IExoplanetRepository exoplanetRepository;

        public ExoplanetService(IExoplanetRepository exoplanet)
        {
            this.exoplanetRepository = exoplanet;
        }

        public List<Exoplanet> GetAll()
        {
            return exoplanetRepository.GetAll();
        }

        public Exoplanet GetId(int id)
        {
            return exoplanetRepository.GetId(id);
        }
    }
}
