using Deezer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Interfaces
{
    public interface IPlaylistTreck
    {
        IEnumerable<PlayListTreck> GetPlaylistTrecks { get; set; }
        PlayListTreck GetPlaylistTreck(int id);
    }
}
