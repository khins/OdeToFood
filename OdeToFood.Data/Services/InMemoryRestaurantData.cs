using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id =1, Cuisine= CuisineType.Italian, Name="Pizza Place"},
                new Restaurant { Id =2, Cuisine= CuisineType.French, Name="French Place"},
                new Restaurant { Id =1, Cuisine= CuisineType.Indian, Name="Mango Grove"},
            };
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name); 
        }
    }
}
