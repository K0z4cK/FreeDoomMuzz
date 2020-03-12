using Deezer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.ViewModels
{
    public class AddTreckViewModel
    {
        public string Name { get; set; }
        public int Rate { get; set; }
        public string Image { get; set; }

        public int GenreId { get; set; }

        public int AlbumId { get; set; }
        public string UserProfileId { get; set; }
        public int FileId { get; set; }
    }
}
