using Microsoft.OpenApi.Models;
using Persistence.Db;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Application.Activities;
using Application.Core;
using Application.Interfaces;
using Infrastructure.Security;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static WebApplicationBuilder AddApplicationServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
        });

        builder.Services.AddCors(opt =>
        {
            opt.AddPolicy("CorsPolicy", policy =>
            {
                policy.AllowAnyMethod()
                .AllowAnyHeader()
                .WithOrigins("http://localhost:3000");
            });
        });

        builder.Services.AddDbContext<DataContext>((serviceProvider, options) =>
            options

#if DEBUG
            .EnableSensitiveDataLogging()
#endif
            .UseNpgsql(builder.Configuration.GetConnectionString(nameof(DataContext)))
        );

        builder.Services.AddMediatR(typeof(List.Handler).Assembly);
        builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
        builder.Services.AddScoped<IUserAccessor, UserAccessor>();

        return builder;
    }
}
