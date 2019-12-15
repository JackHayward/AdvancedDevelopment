using System;
using AdvancedDevelopment.Areas.Identity.Data;
using AdvancedDevelopment.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

[assembly: HostingStartup(typeof(AdvancedDevelopment.Areas.Identity.IdentityHostingStartup))]
namespace AdvancedDevelopment.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<AdvancedDevelopmentContext>(options =>
                    options.UseNpgsql(context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<AdvancedDevelopmentContext>();
            });
        }
    }
}