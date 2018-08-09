using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.Repository
{
    public static class RepositoryFactory
    {
        public static FoodRepository FoodRepositoryFactory() 
            => new FoodRepository();
    }
}
