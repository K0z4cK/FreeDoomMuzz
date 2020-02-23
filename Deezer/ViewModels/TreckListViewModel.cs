using Deezer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.ViewModels
{
    public class TreckListViewModel
    {
        public IEnumerable<Treck> GetTrecks { get; set; }
        public string TreckGenre { get; set; }
    }
}
