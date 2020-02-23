using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Models
{
    public class File
    {
        [Key, ForeignKey("Treck")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Path { get; set; }
        [Required]
        public DateTime Registered { get; set; }
        [Required]
        public string RegisteredBy { get; set; }
        virtual public Treck Treck { get; set; }
    }
}
