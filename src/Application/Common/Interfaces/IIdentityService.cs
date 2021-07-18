using GFCA.Application.Common.Models;
using System.Threading.Tasks;

namespace GFCA.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(int userId);
        Task<(Result Result, int UserId)> CreateUserAsync(string userName, string password);
        Task<Result> DeleteUserAsync(int userId);


    }
}
