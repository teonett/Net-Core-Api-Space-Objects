using System;
using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Services
{
    public class CometService : ICometService
    {
        private readonly ICometRepository cometRepository;

        public CometService(ICometRepository _cometRepository)
        {
            this.cometRepository = _cometRepository;
        }

        public List<Comet> GetAll()
        {
            var resultData = cometRepository.GetAll();
            return resultData;
        }

        public Comet GetId(int id)
        {
            var resultData = cometRepository.GetId(id);
            return resultData;
        }
    }
}
