namespace AspNetCore_Angular_Template.Web.Infrastructure.Services
{
    using System.Security.Claims;
    using AspNetCore_Angular_Template.Web.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Http;

    public class CurrentUserService : ICurrentUserService
    {
        private readonly ClaimsPrincipal user;
        private readonly IHttpContextAccessor HttpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
            => this.user = this.HttpContextAccessor?.HttpContext.User;

        public string GetId()
            => this.user?.GetId();

        public string GetUserName()
            => this.user?.Identity?.Name;
    }
}
