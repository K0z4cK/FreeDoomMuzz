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
    public class AlbumRepository : IAlbums
    {
        private readonly EFContext _context;
        public AlbumRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Album> GetAlbums { get { return _context.Albums.Include(x => x.UserProfile); } set { } }
        public IEnumerable<Album> GetAlbumsByArtist(string artistId)
        {
            return _context.Albums.Include(x => x.UserProfile.Id == artistId);
        }

        public Album GetAlbum(int id)
        {
            return _context.Albums.FirstOrDefault(x => x.Id == id);
        }

        public Album GetAlbumByTreck(int treckId)
        {
            int albId = _context.Trecks.FirstOrDefault(x => x.Id == treckId).AlbumId;
            return _context.Albums.FirstOrDefault(x => x.Id == albId);
        }
    }
}
