using Deezer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Interfaces
{
    public interface IGenres
    {
        IEnumerable<Genre> GetGenres { get; set; }
        Genre GetGenre(int id);
    }
}
