using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExoplanetController : Controller
    {
        private readonly IExoplanetService exoplanetService;

        public ExoplanetController(IExoplanetService exoplanet)
        {
            this.exoplanetService = exoplanet;
        }

        // GET: api/values
        [HttpGet]
        public List<Exoplanet> Get()
        {
            return exoplanetService.GetAll();
        }

        [HttpGet]
        public IActionResult List<Exoplanet>()
        {
            return View(exoplanetService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
