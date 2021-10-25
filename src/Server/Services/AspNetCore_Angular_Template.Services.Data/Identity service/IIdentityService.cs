namespace AspNetCore_Angular_Template.Services.Data
{
    public interface IIdentityService
    {
        string GenerateJwtToken(string userId, string userName, string secret);
    }
}
