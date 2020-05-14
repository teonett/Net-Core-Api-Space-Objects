using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Repositories.Interfaces
{
    public interface IGalaxyRepository
    {
        List<Galaxy> GetAll();

        Galaxy GetId(int id);
    }
}
