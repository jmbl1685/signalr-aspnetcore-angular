using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignalR.Entities;
using SignalR.Repository;

namespace SignalR.API.Controllers
{
    [Route("api/food")]
    [ApiController]
    public class FoodController : ControllerBase
    {

        [HttpGet]
        public async Task<IEnumerable<Food>> Get()
            => await RepositoryFactory.FoodRepositoryFactory().FoodList();

    }
}
