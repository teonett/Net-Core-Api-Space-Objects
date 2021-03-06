﻿using System.Collections.Generic;
using NetCoreSpaceApi.Repositories.Entities;

namespace NetCoreSpaceApi.Repositories.Interfaces
{
    public interface IPlanetRepository
    {
        List<Planet> GetAll();

        Planet GetId(int id);

    }
}
