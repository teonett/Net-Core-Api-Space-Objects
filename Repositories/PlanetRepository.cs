﻿using System.Collections.Generic;
using System.Linq;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Repositories.Interfaces;

namespace NetCoreSpaceApi.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly ApplicationContext context;

        public PlanetRepository(ApplicationContext _context) 
        {
            this.context = _context;
        }

        public List<Planet> GetAll()
        {
            var resultData = context.Planet.ToList();
            return resultData;
        }

        public Planet GetId(int id)
        {
            var resultData = context.Planet.ToList().Where(x => x.Id == id).FirstOrDefault();
            return resultData;
        }
    }
}
