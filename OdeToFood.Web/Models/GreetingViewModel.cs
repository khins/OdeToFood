using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Web.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<IRestaurantData> Restaurants { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}