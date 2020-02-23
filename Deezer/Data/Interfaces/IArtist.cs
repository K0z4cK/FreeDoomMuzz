using Deezer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Interfaces
{
    public interface IArtist
    {
        IEnumerable<UserProfile> GetArtists { get; set; }
        UserProfile GetArtist(string id);
        UserProfile GetArtistByAlbum(int albumId);
        UserProfile GetArtistByTreck(int treckId);
    }
}
