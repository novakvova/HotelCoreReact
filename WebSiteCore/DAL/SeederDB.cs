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
        private static EFDbContext _ctx;
        public SeederDB(EFDbContext context)
        {
            _ctx = context;
        }
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
        public static void SeedClients(UserManager<DbUser> userManager)
        {
            _ctx.Clients.Add(new Client
            {
                Rating = 12,
                User = userManager.FindByEmailAsync("admin@gmail.com").Result
            });
        }
        public static void SeedData(IServiceProvider services)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                SeederDB.SeedUsers(manager, managerRole);               
            }
        }
    }
}
