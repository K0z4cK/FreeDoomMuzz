using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deezer.Data.Entities;
using Deezer.Data.Interfaces;
using Deezer.Data.Models;
using Deezer.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Deezer.Controllers
{
    public class ArtistController : Controller
    {
        private readonly UserManager<DbUser> _userManager;
        private readonly IUser _myUser;
        private readonly ITreck _trecks;
        private readonly IPlaylist _playlists;
        private readonly IPlaylistTreck _playlistsTreck;
        private readonly IGenres _genres;
        private readonly IAlbums _albums;
        private readonly IArtist _artist;

        public ArtistController(UserManager<DbUser> userManager, IUser myUser, ITreck trecks, IPlaylist playlists, IPlaylistTreck playlistsTreck, IGenres genres, IAlbums albums, IArtist artist)
        {
            _userManager = userManager;
            _myUser = myUser;
            _trecks = trecks;
            _playlists = playlists;
            _playlistsTreck = playlistsTreck;
            _genres = genres;
            _albums = albums;
            _artist = artist;
        }
        [HttpGet]
        public IActionResult AddTreck()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTreck(AddTreckViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult CreateAlbum()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAlbum(CreateAlbumViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Album newAlbum = new Album
            {
                countOfTrecks = 0,
                Rate = 0,
                Name = model.Name,
                //UserProfile = _userManager.GetUserId()
            };


            return RedirectToAction("Index", "Home");
        }
    }
}