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
    public class PlaylistRepository : IPlaylist
    {
        private readonly EFContext _context;
        public PlaylistRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<PlayList> GetPlaylists { get { return _context.PlayLists.Include(x => x.UserProfile).Include(x=> x.PlayListTrecks); } set { } }

        public PlayList GetPlaylist(int id)
        {
            return _context.PlayLists.Include(x => x.UserProfile).Include(x => x.PlayListTrecks).Include(x => x.PlayListTrecks).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<PlayList> GetPlaylistsByArtist(string artistId)
        {
            return _context.PlayLists.Include(x => x.UserProfile).Include(x => x.PlayListTrecks).Where(x=> x.UserProfile.Id == artistId);
        }
    }
}
