namespace ApplicationCore.Identity
{
    public interface IIdentityService
    {
        Task<string> GetTokenAsync(string userName);

        Task<string> Authenticate(string userName, string password);

        Task CreateUserAsync(string username, string email, string password);
    }
}
