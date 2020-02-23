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
    public class ArtistRepository : IArtist
    {
        private readonly EFContext _context;
        public ArtistRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<UserProfile> GetArtists { get { return _context.UserProfiles.Include(x => x.User); } set { } }

        public UserProfile GetArtist(string id)
        {
            return _context.UserProfiles.Include(x=> x.User).FirstOrDefault(x => x.Id.ToString() == id);
        }

        public UserProfile GetArtistByAlbum(int albumId)
        {
            string artId = _context.Albums.FirstOrDefault(x => x.Id == albumId).UserProfile.Id;
            return _context.UserProfiles.Include(x => x.User).FirstOrDefault(x => x.Id== artId);
        }

        public UserProfile GetArtistByTreck(int treckId)
        {
            string artId = _context.Trecks.FirstOrDefault(x => x.Id== treckId).UserProfile.Id;
            return _context.UserProfiles.Include(x => x.User).FirstOrDefault(x => x.Id == artId);
        }
    }
}
