using Deezer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Interfaces
{
    public interface IUser
    {
        IEnumerable<DbUser> GetUsers { get; set; }
        DbUser GetUser(string id);
        DbUser GetUserByEmail(string email);
    }
}
