using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Services.Interfaces
{
    public interface IPlanetService
    {
        List<Planet> GetAll();

        Planet GetId(int id);
    }
}
