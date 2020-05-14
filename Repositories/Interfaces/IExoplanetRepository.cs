using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Repositories.Interfaces
{
    public interface IExoplanetRepository
    {
        List<Exoplanet> GetAll();

        Exoplanet GetId(int id);
    }
}
