using SignalR.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.Repository
{
    public interface IFoodRepository
    {
        Task<List<Food>> FoodList();
    }
}
