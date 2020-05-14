using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Services.Interfaces
{
    public interface IGalaxyService
    {
        List<Galaxy> GetAll();

        Galaxy GetId(int id);
    }
}
