using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstelationController : Controller
    {
        private ApplicationContext Context { get; set; }
        private readonly IConstelationService Service;

        public ConstelationController(ApplicationContext _context, IConstelationService constelation)
        {
            this.Context = _context;
            this.Service = constelation;
        }

        /// <summary>
        /// Get List All Known Constelations
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Constelation> Get()
        {
            return Service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Constelation Get(int id)
        {
            return null;
        }
    }
}
