using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Models
{
    public class Treck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public int GenreId { get; set; }
        virtual public Genre Genre { get; set; }

        public int AlbumId { get; set; }
        virtual public Album Album { get; set; }

        virtual public UserProfile UserProfile { get; set; }

    }
}
