using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Repositories.Interfaces
{
    public interface IMoonRepository
    {
        List<Moon> GetAll();

        Moon GetId(int id);
    }
}
