﻿using GFCA.Application.Common.Interfaces;
using GFCA.Application.Common.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GFCA.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public IdentityService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IdentityService(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<string> GetUserNameAsync(int userId)
        {
            var user = await _userManager.Users.FirstAsync(u => u.Id == userId);

            return user.UserName;
        }
        public async Task<(Result Result, int UserId)> CreateUserAsync(string userName, string password)
        {
            var user = new User
            {
                UserName = userName,
                Email = userName,
            };

            var result = await _userManager.CreateAsync(user, password);

            return (result.ToApplicationResult(), user.Id);
        }
        public async Task<Result> DeleteUserAsync(int userId)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

            if (user != null)
            {
                return await DeleteUserAsync(user);
            }

            return Result.Success();
        }
        public async Task<Result> DeleteUserAsync(User user)
        {
            var result = await _userManager.DeleteAsync(user);

            return result.ToApplicationResult();
        }

    }
}
