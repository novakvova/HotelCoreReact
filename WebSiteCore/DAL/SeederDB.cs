﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.DAL.Entities
{
    public class SeederDB
    {
        public static void SeedUsers(UserManager<DbUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            var email = "admin@gmail.com";
            var roleName = "Admin";
            var count = userManager.Users.Count();
            if (count == 0)
            {
                var user = new DbUser
                {
                    Email = email,
                    UserName = email
                };
                var result = userManager.CreateAsync(user, "Qwerty1-").Result;

                var roleresult = roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                }).Result;

                result = userManager.AddToRoleAsync(user, roleName).Result;
            }

        }
        public static void SeedClients(UserManager<DbUser> userManager, EFDbContext context)
        {
            var user = userManager.FindByEmailAsync("admin@gmail.com").Result;
            if (user != null)
            {
                context.Clients.Add(new Client
                {
                    Rating = 12,
                    Id=user.Id
                });
                context.SaveChanges();
            }
        }
        public static void SeedData(IServiceProvider services)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
                SeederDB.SeedUsers(manager, managerRole);
                SeederDB.SeedClients(manager, context);
            }
        }
    }
}
