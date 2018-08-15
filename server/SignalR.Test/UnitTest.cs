using SignalR.API.Controllers;
using SignalR.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace SignalR.Test
{
    public class UnitTest
    {

        private List<Food> foodList = new List<Food>();

        [Fact]
        public async Task FoodControllerTest()
        {
            FoodController foodController = new FoodController();
            var foodList = await foodController.Get();
            Assert.NotNull(foodList);
            Assert.Equal(5,foodList.Count);
        }
    }
}
