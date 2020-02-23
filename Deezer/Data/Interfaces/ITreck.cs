using Deezer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Interfaces
{
    public interface ITreck
    {
        IEnumerable<Treck> GetTrecks { get; set; }
        IEnumerable<Treck> GetBestTrecks { get; set; }
        IEnumerable<Treck> GetTrecksByGenre (int genreId);
        IEnumerable<Treck> GetTrecksByAlbum(int albumId);
        IEnumerable<Treck> GetTrecksByArtist(string artistId);
        Treck GetTreck(int id);
    }
}
