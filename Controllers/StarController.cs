using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCoreSpaceApi.Repositories.Entities;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarController : Controller
    {
        private readonly IStarService starService;

        public StarController(IStarService star)
        {
            this.starService = star;
        }

        // GET: api/values
        [HttpGet]
        public List<Star> Get()
        {
            return starService.GetAll();
        }
    }
}
