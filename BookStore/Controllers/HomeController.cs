using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ViewResult Index()
        {
          
           return View();
        }
        [Authorize]
        public ViewResult AboutUs()
        {
            return View();
        }
        [Authorize]
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
