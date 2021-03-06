﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : Controller
    {
        private ApplicationContext Context { get; set; }
        private readonly IPlanetService PlanetService; 

        public PlanetController(ApplicationContext _context, IPlanetService planetService)
        {
            this.Context = _context;
            this.PlanetService = planetService;
        }

        /// <summary>
        /// Get List Our Solar System Planets
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Planet> Get()
        {
            return PlanetService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Planet Get(int id)
        {
            return null;
        }

    }
}
