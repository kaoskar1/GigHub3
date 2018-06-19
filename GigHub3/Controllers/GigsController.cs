using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigHub3.Models;
using GigHub3.ViewModels;

namespace GigHub3.Controllers
{
    public class GigsController : Controller
    {


        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Gigs
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Create()
        {
            var ViewModel = new GigFormViewModel
            {

                Genres = _context.Genres.ToList()

            };

           return View(ViewModel);
        }
    }
}