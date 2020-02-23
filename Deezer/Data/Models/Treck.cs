using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Models
{
    public class Treck
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public string Image { get; set; }

        public int GenreId { get; set; }
        virtual public Genre Genre { get; set; }

        public int AlbumId { get; set; }
        virtual public Album Album { get; set; }
        public string UserProfileId { get; set; }
        virtual public UserProfile UserProfile { get; set; }
        public int FileId { get; set; }
        virtual public File File { get; set; }

        public virtual ICollection<PlayListTreck> PlayListTreck { get; set; }

    }
}
