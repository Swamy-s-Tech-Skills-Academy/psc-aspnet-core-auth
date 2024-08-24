using Globomantics.ApplicationCore.Interfaces;
using Globomantics.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace GlobomanticsCookieAuth.Web.Extensions;

public static class ServiceConfigurationExtensions
{
    public static void AddConfiguredServices(this WebApplicationBuilder builder)
    {
        _ = builder.Services.AddControllersWithViews();

        _ = builder.Services.AddRazorPages();

        _ = builder.Services.AddScoped<IConferenceRepository, ConferenceRepository>();

        _ = builder.Services.AddScoped<IProposalRepository, ProposalRepository>();

        _ = builder.Services.AddScoped<IUserRepository, UserRepository>();

        _ = builder.Services.AddAuthentication(options =>
        {
            options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        })
         .AddCookie();
    }

}