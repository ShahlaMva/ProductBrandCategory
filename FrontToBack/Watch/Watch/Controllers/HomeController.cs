using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Watch.DAL;
using Watch.ViewModels;

namespace Watch.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = _db.Sliders,
                //Products=_db.Products,
                WatchImages=_db.WatchImages
            };
            return View(homeViewModel);
        }
    }
}