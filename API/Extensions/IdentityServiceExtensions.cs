using API.Services;
using Domain.Entities;
using Infrastructure.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Persistence.Db;
using System.Text;

namespace API.Extensions;

public static class IdentityServiceExtensions
{
    public static WebApplicationBuilder AddIdentityServices (this WebApplicationBuilder builder)
    {
        builder.Services.AddIdentityCore<AppUser>(opt =>
        {
            opt.Password.RequireNonAlphanumeric = false;
            opt.Password.RequireUppercase = true;
            opt.Password.RequireLowercase = true;
        })
        .AddEntityFrameworkStores<DataContext>()
        .AddSignInManager<SignInManager<AppUser>>();

        //JWT Configuration                When using ASCII UTF8 will give you 1 byte per char. So you need at least 16 chars. calculation: 16 * 8bit (1 char = 2byte) = 128bit
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"])); // saved this key in localstorage

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = key
                };
            });

        builder.Services.AddAuthorization(opt =>
        {
            opt.AddPolicy("IsActivityHost", policy =>
            {
                policy.Requirements.Add(new IsHostRequirement());
            });
        });

        builder.Services.AddTransient<IAuthorizationHandler, IsHostRequirementHandler>();
        builder.Services.AddScoped<TokenService>();
        
        return builder;
    }
}
