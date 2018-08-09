using Microsoft.AspNetCore.SignalR;
using SignalR.Entities;
using SignalR.ExtensionUtility;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.API.Hubs
{
    public class AllHubs : Hub
    {
        /* TODO: Cambiar, Esto es una prueba rápida, el código no es óptimo. */
        public async Task AddFoodStar (string FoodId)
        {
            Food food = null;
            int index = -1;

            var FoodList = await Repository.RepositoryFactory.FoodRepositoryFactory().FoodList();
            FoodList.ToList().map((item,i) =>
            {
                if (item.FoodId == FoodId)
                {
                    item.FoodStar += 1;
                    food = new Food();
                    food = item;
                    index = i;
                }
                   
            });

            await Clients.All.SendAsync("FoodStar", new { Food = food, Index = index});
        }

    }
}
