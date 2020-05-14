using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Services.Interfaces
{
    public interface IExoplanetService
    {
        List<Exoplanet> GetAll();

        Exoplanet GetId(int id);
    }
}
