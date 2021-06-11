using Food2Share2.ServiceLayor;
using Food2Share2.ServiceLayor.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fodd2Share2.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly RestaurantService _restaurantService;
        public RestaurantController(RestaurantService restaurantservice)
        {
            _restaurantService = restaurantservice ?? throw new ArgumentNullException(nameof(restaurantservice));
        }
        public IActionResult Restaurant()
        {
            return View();
        }
        public IActionResult CreateRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] AddRestaurantViewModel addRestaurantViewModel)
        {
            //to do call to service
            //restaurantService.AddRestarant(addRestaurantViewModel);
            return RedirectToAction(nameof(Restaurant)) ;
        }
        //// GET: RestaurantController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: RestaurantController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: RestaurantController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: RestaurantController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RestaurantController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: RestaurantController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RestaurantController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: RestaurantController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
