using Microsoft.AspNetCore.Identity;
using System;

namespace StandardlyDemoProject2.Api.Models.Users
{
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
        public virtual ApplicationUser User { get; set; }
    }
}
