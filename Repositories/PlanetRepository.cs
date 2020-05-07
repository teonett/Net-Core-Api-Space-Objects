using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;

namespace NetCoreSpaceApi.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        public PlanetRepository()
        {
        }

        public Task Create(Planet planet)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetAll(List<Planet> planets)
        {
            throw new NotImplementedException();
        }

        public Task GetId(int id)
        {
            throw new NotImplementedException();
        }

        public Task Import(List<Planet> planets)
        {
            throw new NotImplementedException();
        }

        public Task Update(Planet planet)
        {
            throw new NotImplementedException();
        }
    }
}
