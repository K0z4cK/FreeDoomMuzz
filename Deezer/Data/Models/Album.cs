using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int countOfTrecks { get; set; }
        public int UserProfileId { get; set; }
        virtual public UserProfile UserProfile { get; set; }
        public ICollection<Treck> Trecks { get; set; }
    }
}
