using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Repositories.Interfaces
{
    public interface ICometRepository
    {
        List<Comet> GetAll();

        Comet GetId(int id);
    }
}
