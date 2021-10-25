namespace AspNetCore_Angular_Template.Web.Infrastructure.Services
{
    public interface ICurrentUserService
    {
        string GetId();

        string GetUserName();
    }
}
