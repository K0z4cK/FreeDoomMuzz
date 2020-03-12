using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.ViewModels
{
    public class CreateAlbumViewModel
    {
        public string Name { get; set; }
        public int Rate { get; set; }
        public string Image { get; set; }

        public int countOfTrecks { get; set; }
    }
}
