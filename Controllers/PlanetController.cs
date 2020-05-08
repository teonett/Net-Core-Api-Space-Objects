using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public IActionResult List<Planet>()
        {
            return View(PlanetService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Planet Get(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
