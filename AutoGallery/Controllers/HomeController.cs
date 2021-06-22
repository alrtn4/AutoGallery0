using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoGallery.Repositories;
using AutoGallery.Models;
using AutoGallery;

namespace AutoGallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly BannerImageRepository _bannerRepo;

        public HomeController(BannerImageRepository bannerRepo)
        {
            _bannerRepo = bannerRepo;
        }

        public HomeController()
        {

        }
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddImage()
        {
            return View();
        }
    }
}