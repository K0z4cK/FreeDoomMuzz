using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deezer.Data.Interfaces;
using Deezer.Data.Models;
using Deezer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Deezer.Controllers
{
    public class MusicController : Controller
    {
        private readonly ITreck _trecks;
        private readonly IGenres _genres;
        private readonly IAlbums _albums;
        private readonly IArtist _artist;

        public MusicController(ITreck trecks, IGenres genres, IAlbums albums, IArtist artist)
        {
            _trecks = trecks;
            _genres = genres;
            _albums = albums;
            _artist = artist;
        }
        [Route("Music/ListTreks")]
        [Route("Music/ListTreks/{genre}")]
        public ViewResult ListTreks(string category)
        {
            //var info = HttpContext.Session.GetString("SessionUser");
            //if (info != null)
            //{
            //    var result = JsonConvert.DeserializeObject<UserInfo>(info);
            //}
            IEnumerable<Treck> treks = null;
            string treksGenre = "";
            if (string.IsNullOrEmpty(category))
            {
                treks = _trecks.GetTrecks.OrderBy(t => t.Id);
            }
            else
            {
                treks = _trecks.GetTrecks
                    .Where(x => x.Genre.GenreName.ToLower() == category.ToLower());
                treksGenre = category;
            }
            var treckObj = new TreckListViewModel
            {
                GetTrecks = treks,
                TreckGenre = treksGenre
            };

            return View(treckObj);
            //ViewBag.Title = "All Cars";
            //CarListViewModel obj = new CarListViewModel();
            //obj.GetCars = _cars.GetCars;
            //obj.CarCategory = "Electricity";
            ////var cars = _cars.GetCars;
            ////return View(cars);
            //return View(obj);
            //return View();
        }
    }
}