using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Quark.Core.Abstractions.Serialization.Options;
using Quark.Core.Abstractions.Serialization.Serializers;
using Quark.Core.Abstractions.Serialization.Settings;
using Quark.Core.Permissions;
using Quark.Core.Serialization.JsonConverters;
using Quark.Core.Serialization.Options;
using Quark.Core.Serialization.Serializers;
using Quark.Core.Serialization.Settings;

namespace Quark.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIdentityServices<TUser, TRole, TContext>(this IServiceCollection services) 
        where TUser : IdentityUser 
        where TRole : IdentityRole 
        where TContext : IdentityDbContext
    {
        services.AddTransient<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
        services.AddTransient<IAuthorizationHandler, PermissionAuthorizationHandler>();
        services.AddIdentity<TUser, TRole>().AddEntityFrameworkStores<TContext>().AddDefaultTokenProviders();
        return services;
    }

    public static IServiceCollection AddSerialization(this IServiceCollection services)
    {
        services
            .AddScoped<IJsonSerializerOptions, SystemTextJsonOptions>()
            .Configure<SystemTextJsonOptions>(configureOptions =>
            {
                if (!configureOptions.JsonSerializerOptions.Converters.Any(c => c.GetType() == typeof(TimespanJsonConverter)))
                    configureOptions.JsonSerializerOptions.Converters.Add(new TimespanJsonConverter());
            });
        services.AddScoped<IJsonSerializerSettings, NewtonsoftJsonSettings>();

        services.AddScoped<IJsonSerializer, SystemTextJsonSerializer>(); // you can change it
        return services;
    }
}