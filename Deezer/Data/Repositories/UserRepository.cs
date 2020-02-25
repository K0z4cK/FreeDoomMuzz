using Deezer.Data.Entities;
using Deezer.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Repositories
{
    public class UserRepository : IUser
    {
        private readonly EFContext _context;
        public UserRepository(EFContext context)
        {
            _context = context;
        }
        public IEnumerable<DbUser> GetUsers { get { return _context.Users.Include(x => x.UserProfile).Include(x => x.UserRoles); } set { } }

        public DbUser GetUser(string id)
        {
            return _context.Users.Include(x => x.UserProfile).Include(x => x.UserRoles).FirstOrDefault(x => x.Id.ToString() == id);
        }
        public DbUser GetUserByEmail(string email)
        {
            return _context.Users.Include(x => x.UserProfile).Include(x => x.UserRoles).FirstOrDefault(x => x.Email == email);

        }
    }
}
