using Deezer.Data.Entities;
using Deezer.Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deezer.Data.Seed
{
    public class SeederDb
    {
        public static void SeedData(IServiceProvider services, IHostingEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();
                var context = scope.ServiceProvider.GetRequiredService<EFContext>();
                var roleName = "Admin";
                var roleName2 = "Artist";
                if (!context.Roles.Any(r => r.Name == roleName2))
                {
                    var result2 = managerRole.CreateAsync(new DbRole
                    {
                        Name = roleName2
                    }).Result;
                }
                if (!context.Roles.Any(r => r.Name == roleName))
                {
                    var result = managerRole.CreateAsync(new DbRole
                    {
                        Name = roleName
                    }).Result;
                }
                UserProfile userProfile = new UserProfile
                {
                    FirstName = "Kozack",
                    LastName = "Rovenskiy",
                    RegistrationDate = DateTime.Now
                };
                DbUser user = new DbUser
                {
                    Email = "2003.illya@gmail.com",
                    UserName = "K0z4cK",
                    UserProfile = userProfile
                };


                UserProfile userProfile1 = new UserProfile
                {
                    FirstName = "Kurt",
                    LastName = "Cobain",
                    RegistrationDate = DateTime.Now
                };
                DbUser user1 = new DbUser
                {
                    Email = "died1994@pressf.com",
                    UserName = "Kurty",
                    UserProfile = userProfile1
                };
                var result02 = manager.CreateAsync(user1, "Qwerty-1").Result;
                result02 = manager.AddToRoleAsync(user1, roleName2).Result;
                var result01 = manager.CreateAsync(user, "Qwerty-1-2").Result;
                result01 = manager.AddToRoleAsync(user, roleName).Result;
            }
        }

    }
}
