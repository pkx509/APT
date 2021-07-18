using GFCA.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace GFCA.WebAPI.Services
{
    public class CurrentUserService : ICurrentUserService
    {

        public int? UserId { get; }
        public string UserEmail { get; }
        public string UserName { get; }
        public string UserRole { get; }

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            var nameIdentifier = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            UserId = string.IsNullOrEmpty(nameIdentifier)? -1 : int.Parse(nameIdentifier);
            UserEmail = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Email);
            UserRole = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Role);
            UserName = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Name);
        }

    }
}
