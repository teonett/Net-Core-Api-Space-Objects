using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Services
{
    public class MoonService : IMoonService
    {
        private readonly IMoonRepository moonRepository;

        public MoonService(IMoonRepository moon)
        {
            this.moonRepository = moon;
        }

        public List<Moon> GetAll()
        {
            return moonRepository.GetAll();
        }

        public Moon GetId(int id)
        {
            return moonRepository.GetId(id);
        }
    }
}
