using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Services.Interfaces
{
    public interface ICometService
    {
        List<Comet> GetAll();

        Comet GetId(int id);
    }
}
