using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Repositories.Interfaces
{
    public interface IStarRepository
    {
        List<Star> GetAll();

        Star GetId(int id);
    }
}
