using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigHub3.Models;
using GigHub3.ViewModels;
using Microsoft.AspNet.Identity;

namespace GigHub3.Controllers
{
    public class GigsController : Controller
    {


        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
       
        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new GigFormViewModel
            {

                Genres = _context.Genres.ToList()

            };

           return View(ViewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = _context.Genres.ToList();
                return View("Create", viewModel);
            }

            var gig = new Gig
            {
                ArtistId  = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return
            RedirectToAction("Index", "Home");
        }
    }
}