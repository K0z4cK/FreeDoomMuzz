using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Deezer.Models;
using Deezer.Data.Interfaces;
using Deezer.ViewModels;

namespace Deezer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITreck _trecks;
        private readonly IGenres _genres;
        private readonly IAlbums _albums;
        private readonly IArtist _artist;

        public HomeController(ITreck trecks, IGenres genres, IAlbums albums, IArtist artist)
        {
            _trecks = trecks;
            _genres = genres;
            _albums = albums;
            _artist = artist;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Best Treks";
            var treks = new HomeViewModel
            {
                BestTreks = _trecks.GetBestTrecks
            };
            return View(treks);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
