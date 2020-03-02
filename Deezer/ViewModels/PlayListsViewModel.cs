using Deezer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.ViewModels
{
    public class PlayListsViewModel
    {
        public IEnumerable<PlayList> GetPlaylists { get; set; }
    }
}
