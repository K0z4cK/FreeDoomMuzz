using Deezer.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Components
{
    public class Player : ViewComponent
    {
        private readonly ITreck _player;
        public Player(ITreck player)
        {
            _player = player;
        }
        public IViewComponentResult Invoke(int id)
        {
            var treck = _player.GetTreck(id);
            return View(treck);
        }
    }
}
