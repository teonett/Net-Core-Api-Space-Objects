using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Repositories.Interfaces
{
    public interface IPlanetRepository
    {
        Task GetAll(List<Planet> planets);

        Task GetId(int id);

        Task Import(List<Planet> planets);

        Task Create(Planet planet);

        Task Update(Planet planet);

        Task Delete(int id);
    }
}
