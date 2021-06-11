using Fodd2Share2.Repository;
using Food2Share2.Domain;
using Food2Share2.ServiceLayor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food2Share2.ServiceLayor
{
    public class RestaurantService
    {
        private readonly ApplicationDbContext _applicationDbContext; 
        public RestaurantService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(ApplicationDbContext));
        }

        public void AddRestaurant(AddRestaurantViewModel addRestaurantViewModel)
        {
            Restaurant restaurant = new Restaurant()
            {
                Name = addRestaurantViewModel.Name
            };

            _applicationDbContext.Add(restaurant);
            _applicationDbContext.SaveChanges();
        }

        public static void AddRestarant()
        {
            throw new NotImplementedException();
        }
    }
}