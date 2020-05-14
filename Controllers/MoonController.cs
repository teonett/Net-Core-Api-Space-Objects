using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoonController : ControllerBase
    {
        private readonly IMoonService MoonService;

        public MoonController(IMoonService moon)
        {
            this.MoonService = moon;
        }

        // GET: api/values
        [HttpGet]
        public List<Moon> Get()
        {
            return MoonService.GetAll();
        }

    }
}
