namespace GFCA.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        int? UserId { get; }
        string UserEmail { get; }
        string UserName { get; }
        string UserRole { get; }
    }
}
