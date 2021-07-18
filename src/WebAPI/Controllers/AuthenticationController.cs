using System;
using System.Threading.Tasks;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace GFCA.WebAPI.Controllers
{
    public class AuthenticationController : ApiControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IIdentityServerInteractionService _interactionService;
        private readonly IWebHostEnvironment _env;
        public AuthenticationController(SignInManager<IdentityUser> signInManager,
            IIdentityServerInteractionService interactionService,
            IWebHostEnvironment env)
        {
            _signInManager = signInManager;
            _interactionService = interactionService;
            _env = env;
        }
        /*
        [HttpGet("logout")]
        public async Task<IActionResult> Logout(string logoutId,
            [FromServices] SignInManager<IdentityUser> signInManager,
            [FromServices] IIdentityServerInteractionService interactionService,
            [FromServices] IWebHostEnvironment env)
        {
            await signInManager.SignOutAsync();

            if (string.IsNullOrEmpty(logoutId))
            {
                return Redirect(env.IsDevelopment() ? "http://localhost:5001/" : "/");
            }

            var logoutContext = await interactionService.GetLogoutContextAsync(logoutId);

            if (string.IsNullOrEmpty(logoutContext.PostLogoutRedirectUri))
            {
                return BadRequest();
            }

            return Redirect(logoutContext.PostLogoutRedirectUri);
        }
        */
        [HttpGet("logout")]
        public async Task<IActionResult> Logout(string logoutId)
        {
            await _signInManager.SignOutAsync();

            if (string.IsNullOrEmpty(logoutId))
            {
                return Redirect(_env.IsDevelopment() ? "http://localhost:5001/" : "/");
            }

            var logoutContext = await _interactionService.GetLogoutContextAsync(logoutId);

            if (string.IsNullOrEmpty(logoutContext.PostLogoutRedirectUri))
            {
                return BadRequest();
            }

            return Redirect(logoutContext.PostLogoutRedirectUri);
        }
    }
}
