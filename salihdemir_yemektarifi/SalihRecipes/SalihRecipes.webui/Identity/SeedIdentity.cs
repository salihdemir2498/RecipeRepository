﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {

            var roles = configuration.GetSection("Data:Roles").GetChildren().Select(x=>x.Value).ToArray();
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role)) //role bilgisinin daha önce veritabanına eklenip eklenilmediğini kontrol ediyoruz
                {
                await roleManager.CreateAsync(new IdentityRole(role));
                    //eğer yoksa
                }
            }
            var users = configuration.GetSection("Data:Users");

            foreach (var section in users.GetChildren())
            {
                var username = section.GetValue<string>("username");
                var password = section.GetValue<string>("password");
                var email = section.GetValue<string>("email");
                var role = section.GetValue<string>("role");
                var firstName = section.GetValue<string>("firstName");
                var lastName = section.GetValue<string>("lastName");

                if (await userManager.FindByNameAsync(username) == null) //daha önce böyle kullanıcı yoksa
                {
                    await roleManager.CreateAsync(new IdentityRole(role));

                    var user = new User()
                    {
                        UserName = username,
                        Email = email,
                        FirstName = firstName,
                        LastName = lastName,
                        EmailConfirmed = true
                    };

                    var result = await userManager.CreateAsync(user, password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, role);

                    }
                }
            }




        }
    }
}
