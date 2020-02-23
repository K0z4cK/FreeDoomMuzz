using Deezer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Interfaces
{
    public interface IAlbums
    {
        IEnumerable<Album> GetAlbums { get; set; }
        IEnumerable<Album> GetAlbumsByArtist(string artistId);
        Album GetAlbum(int id);
        Album GetAlbumByTreck(int treckId);
    }
}
