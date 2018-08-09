using System;

namespace SignalR.Entities
{
    public class Food
    {

        public Food()
        {
            this.FoodId = Guid.NewGuid().ToString();
        }

        public readonly string FoodId;
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public string FoodImage { get; set; }
        public string FoodCountry { get; set; }
        public int FoodStar { get; set; }

    }
}
