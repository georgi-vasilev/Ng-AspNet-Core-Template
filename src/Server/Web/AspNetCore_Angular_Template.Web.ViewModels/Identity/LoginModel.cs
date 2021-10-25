namespace AspNetCore_Angular_Template.Web.Models.Identity
{
    using System.ComponentModel.DataAnnotations;

    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
