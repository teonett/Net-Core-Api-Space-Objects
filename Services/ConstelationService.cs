using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Services
{
    public class ConstelationService : IConstelationService
    {
        private readonly IConstelationRepository constelationRepository;

        public ConstelationService(IConstelationRepository constelation)
        {
            this.constelationRepository = constelation;
        }

        public List<Constelation> GetAll()
        {
            return constelationRepository.GetAll();
        }

        public Constelation GetId(int id)
        {
            return constelationRepository.GetId(id);
        }
    }
}
