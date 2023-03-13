using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Persistence.Db;

namespace API.Extensions;

public static class IdentityServiceExtensions
{
    public static WebApplicationBuilder AddIdentityService (this WebApplicationBuilder builder)
    {
        builder.Services.AddIdentityCore<AppUser>(opt =>
        {
            opt.Password.RequireNonAlphanumeric = false;
        })
        .AddEntityFrameworkStores<DataContext>()
        .AddSignInManager<SignInManager<AppUser>>();

        builder.Services.AddAuthentication();

        return builder;
    }
}
