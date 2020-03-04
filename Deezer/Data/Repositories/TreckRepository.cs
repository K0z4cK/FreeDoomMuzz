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
    public class TreckRepository : ITreck
    {
        private readonly EFContext _context;
        public TreckRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Treck> GetTrecks
        {
            get { return _context.Trecks.Include(x => x.Genre).Include(x => x.UserProfile).Include(x => x.UserProfile.User).Include(x => x.Album).Include(x => x.File); ; }
            set { }
        }
        public IEnumerable<Treck> GetBestTrecks
        {
            get { return _context.Trecks.Where(t => t.Rate >= 9).Include(x => x.Genre).Include(x => x.UserProfile).Include(x => x.UserProfile.User).Include(x => x.Album).Include(x => x.File); }
            set { }
        }
        public IEnumerable<Treck> GetTrecksByAlbum(int albumId)
        {
            return _context.Trecks.Where(x=>x.AlbumId == albumId).Include(x => x.Genre).Include(x => x.UserProfile).Include(x => x.UserProfile.User).Include(x => x.Album).Include(x => x.File);
        }
        public IEnumerable<Treck> GetTrecksByArtist(string artistId)
        {
            return _context.Trecks.Where(x => x.UserProfileId == artistId).Include(x => x.Genre).Include(x => x.UserProfile).Include(x => x.UserProfile.User).Include(x => x.Album).Include(x => x.File);
        }

        public IEnumerable<Treck> GetTrecksByGenre(int genreId)
        {
            return _context.Trecks.Where(x => x.GenreId == genreId).Include(x => x.Genre).Include(x => x.UserProfile).Include(x => x.UserProfile.User).Include(x => x.Album).Include(x => x.File);
        }
        public Treck GetTreck(int id)
        {
            return _context.Trecks.Include(x => x.Genre).Include(x => x.UserProfile).Include(x => x.UserProfile.User).Include(x => x.Album).Include(x => x.File).FirstOrDefault(x => x.Id == id);
        }

      
    }
}
