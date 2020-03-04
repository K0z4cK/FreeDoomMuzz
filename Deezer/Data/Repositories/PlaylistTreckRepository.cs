using Deezer.Data.Entities;
using Deezer.Data.Interfaces;
using Deezer.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Repositories
{
    public class PlaylistTreckRepositor : IPlaylistTreck
    {
        private readonly EFContext _context;
        public PlaylistTreckRepositor(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<PlayListTreck> GetPlaylistTrecks { get { return _context.PlayListTrecks.Include(x => x.Treck).Include(x => x.PlayList); } set { } }

        public PlayListTreck GetPlaylistTreck(int id)
        {
            return _context.PlayListTrecks.Include(x=>x.Treck).Include(x => x.PlayList).FirstOrDefault(x => x.Id == id);
        }
    }
}
