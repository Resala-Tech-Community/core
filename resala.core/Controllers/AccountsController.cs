using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using resala.core.Extensions;
using resala.core.Identity;
using resala.core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class AccountsController : BaseController
    {
        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;

        public AccountsController(IMapper _mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) : base(_mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register(AddAppUserResource newUserResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            AppUser user = new AppUser
            {
                UserName = newUserResource.Email,
                Email = newUserResource.Email,
            };

            var res = await _userManager.CreateAsync(user , newUserResource.Password);
          

            if (!res.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to create new user");

            await _signInManager.SignInAsync(user, isPersistent: false);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> login(LoginUserResource user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var res = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RemeberMe,false);


            if (!res.Succeeded)
                return StatusCode(StatusCodes.Status401Unauthorized, "Login Failed");


            return Ok();
        }



    }
}
