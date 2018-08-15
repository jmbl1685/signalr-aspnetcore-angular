using System.Collections.Generic;
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
        public async Task<List<Food>> Get()
            => await RepositoryFactory.FoodRepositoryFactory().FoodList();

    }
}
