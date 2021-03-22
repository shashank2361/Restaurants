using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RestaurantListings.Data;
using RestaurantListings.Data.Entities;

namespace RestaurantListings.Controllers
{
    [EnableCors()]
    [ApiController]
    [Route("/api/[controller]")]
    public class RestaurantsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public string UserId => User.FindFirstValue(ClaimTypes.NameIdentifier);

        public RestaurantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns all restaurants.
        /// </summary>
        [HttpGet]
        public IEnumerable<Restaurant> Get()
        {
            return _context.Restaurants.ToList();
        }

        [HttpGet]
        [Route("GetbyTags")]
        public IEnumerable<Restaurant> GetbyTags(string tags)
        {
            var tagsList = tags?.Split(',')?.ToList();
            var allList = _context.Restaurants.ToList();
   
   

            var restaurants = (from restaurant in allList
                               let tagexist = tagsList.Any(x => restaurant.Tags.Contains(x))
                               where tagexist == true
                               select restaurant);

 
            return restaurants.ToList();
        }

   
        [HttpPut("{id}")]
        public Restaurant PostRating(int id, Restaurant restaurant)
        {

        

            _context.Restaurants.Update(restaurant);
            _context.SaveChanges();
            return restaurant;
        }
    }
}
