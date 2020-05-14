using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Services.Interfaces
{
    public interface IConstelationService
    {
        List<Constelation> GetAll();

        Constelation GetId(int id);
    }
}
