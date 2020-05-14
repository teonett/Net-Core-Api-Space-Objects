using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalaxyController : Controller
    {
        private readonly IGalaxyService galaxyService;

        public GalaxyController(IGalaxyService galaxy)
        {
            this.galaxyService = galaxy;
        }

        // GET: api/values
        [HttpGet]
        public List<Galaxy> Get()
        {
            return galaxyService.GetAll();
        }

        [HttpGet]
        public IActionResult List<Galaxy>()
        {
            return View(galaxyService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
