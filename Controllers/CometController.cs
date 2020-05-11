using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CometController : Controller
    {
        private ApplicationContext Context { get; set; }
        private readonly ICometService Service;

        public CometController(ApplicationContext _context, ICometService comet)
        {
            this.Context = _context;
            this.Service = comet;
        }

        /// <summary>
        /// Get List All Known Comets
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Comet> Get()
        {
            return Service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Comet Get(int id)
        {
            return null;
        }

    }
}
