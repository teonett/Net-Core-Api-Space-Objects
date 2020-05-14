using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Repositories.Interfaces
{
    public interface IConstelationRepository
    {
        List<Constelation> GetAll();

        Constelation GetId(int id);
    }
}
