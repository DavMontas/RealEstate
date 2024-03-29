﻿using Microsoft.AspNetCore.Identity;
using RealEstate.Core.Application.Enums;
using RealEstate.Infrastructure.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastructure.Identity.Seeds
{
    public static class DefaultAgentUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new();
            defaultUser.UserName = "DefaultAgentUser";
            defaultUser.Email = "DefaultAgentUser@gmail.com";
            defaultUser.FirstName = "Agent";
            defaultUser.LastName = "User";
            defaultUser.IsVerified = true;
            defaultUser.EmailConfirmed = true;
            defaultUser.PhoneNumberConfirmed = true;
            defaultUser.TypeUser = (int)Roles.Agent;

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word!");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Agent.ToString());
                }
            }
        }
    }
}
