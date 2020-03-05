using Deezer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Interfaces
{
    public interface IPlaylist
    {
        IEnumerable<PlayList> GetPlaylists { get; set; }
        IEnumerable<PlayList> GetPlaylistsByArtist(string artistId);
        PlayList GetPlaylist(int id);
    }
}
