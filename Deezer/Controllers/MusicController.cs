﻿using System;
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
        private readonly IPlaylist _playlists;
        private readonly IGenres _genres;
        private readonly IAlbums _albums;
        private readonly IArtist _artist;

        public MusicController(ITreck trecks, IPlaylist playlists,IGenres genres, IAlbums albums, IArtist artist)
        {
            _trecks = trecks;
            _playlists = playlists;
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
        }
        [Route("Music/GetPlaylist/{id}")]
        public ViewResult GetPlaylist(int id)
        {
            //var info = HttpContext.Session.GetString("SessionUser");
            //if (info != null)
            //{
            //    var result = JsonConvert.DeserializeObject<UserInfo>(info);
            //}
            PlayList playList = _playlists.GetPlaylist(id);
            IEnumerable<Treck> treks = null;
            string treksGenre = "";
            foreach (var pltreck in playList.PlayListTrecks)
                treks.Append(pltreck.Treck);
            //if (string.IsNullOrEmpty(category))
            //{
            //    treks = _trecks.GetTrecks.OrderBy(t => t.Id);
            //}
            //else
            //{
            //    treks = _trecks.GetTrecks
            //        .Where(x => x.Genre.GenreName.ToLower() == category.ToLower());
            //    treksGenre = category;
            //}
            var treckObj = new TreckListViewModel
            {
                GetTrecks = treks,
                TreckGenre = treksGenre
            };

            return View(treckObj);
        }
        [Route("Music/Explore")]
        public ViewResult Explore()
        {
            //var info = HttpContext.Session.GetString("SessionUser");
            //if (info != null)
            //{
            //    var result = JsonConvert.DeserializeObject<UserInfo>(info);
            //}
            IEnumerable<PlayList> playlists = null;
            playlists = _playlists.GetPlaylists.OrderBy(t => t.Id);
            var treckObj = new PlayListsViewModel
            {
                GetPlaylists = playlists,
            };

            return View(treckObj);

        }
    }
}