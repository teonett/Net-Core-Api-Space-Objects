using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Services.Interfaces
{
    public interface IStarService
    {
        List<Star> GetAll();

        Star GetId(int id);
    }
}
