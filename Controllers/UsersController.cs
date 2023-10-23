using GI.Models;
using GI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
           _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            //Errorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr
            var users = await _userManager.Users.Select(user => new UsersViewModel
            { 
                Id=user.Id,
                FirstName=user.FirstName,
                LastName=user.LastName,
                Email=user.Email,
                Roles = _userManager.GetRolesAsync(user).Result
            }).ToListAsync();
            return View(users);
        }
    }
}
