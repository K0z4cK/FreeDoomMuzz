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
    public class GenreRepository : IGenres
    {
        private readonly EFContext _context;
        public GenreRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<Genre> GetGenres
        {
            get
            {
                return _context.Genres;
            }
            set { }
        }

        public Genre GetGenre(int id)
        {
            return _context.Genres.FirstOrDefault(x => x.Id == id);
        }
    }
}
