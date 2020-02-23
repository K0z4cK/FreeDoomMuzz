using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Models
{
    public class PlayListTreck
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Treck")]
        public int TreckId { get; set; }

        [ForeignKey("PlayList")]
        public int PlayListId { get; set; }

        public virtual PlayList PlayList { get; set; }

        public virtual Treck Treck { get; set; }
    }
}
