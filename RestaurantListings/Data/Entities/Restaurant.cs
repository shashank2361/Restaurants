using System.Collections.Generic;

namespace RestaurantListings.Data.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public decimal Rating { get; set; }

        public string PhotoUri { get; set; }

        public bool FamilyFriendly { get; set; }

        public bool VeganFriendly { get; set; }

        public List<string> Tags { get; set; }
 
    }
}
