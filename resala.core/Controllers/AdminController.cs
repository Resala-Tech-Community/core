using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using resala.core.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Controllers
{
    [Route("/api/[controller]")]
    public class AdminController : BaseController
    {
        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;

        public AdminController(IMapper _mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) : base(_mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }



        [HttpGet]
        public  IQueryable<AppUser> ListUsers()
        {
            IQueryable<AppUser> users =  _userManager.Users;

            return users;
        }

    }
}
