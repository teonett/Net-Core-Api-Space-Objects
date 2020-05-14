using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Services.Interfaces
{
    public interface IMoonService
    {
        List<Moon> GetAll();

        Moon GetId(int id);
    }
}
