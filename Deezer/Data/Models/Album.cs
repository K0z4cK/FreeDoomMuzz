using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public string Image { get; set; }

        public int countOfTrecks { get; set; }
        virtual public UserProfile UserProfile { get; set; }
        public ICollection<Treck> Trecks { get; set; }
    }
}
