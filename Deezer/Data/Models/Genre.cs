using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string GenreName { get; set; }
        public ICollection<Treck> Trecks { get; set; }
    }
}
