//using System;
//using AdvancedDevelopment.Areas.Identity.Data;
//using AdvancedDevelopment.Models;
//using AdvancedDevelopment.Services;
//using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.AspNetCore.Identity.UI.Services;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Npgsql;

//[assembly: HostingStartup(typeof(AdvancedDevelopment.Areas.Identity.IdentityHostingStartup))]
//namespace AdvancedDevelopment.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public IConfiguration Configuration;

//        public void Configure(IWebHostBuilder builder)
//        {
//            KeyGrabber keyGrabber = new KeyGrabber(Configuration);

//            builder.ConfigureServices((context, services) =>
//            {
//                services.AddDbContext<ApplicationDbContext>(options =>
//                    options.UseNpgsql(context.Configuration.GetConnectionString("DefaultConnection")));

//                services.AddAuthentication().AddGoogle(options =>
//                {
//                    options.ClientId = keyGrabber.GetKey("GoogleClientId");
//                    options.ClientSecret = keyGrabber.GetKey("GoogleClientSecret");
//                });                

//                services.AddIdentity<User, IdentityRole>(config =>
//                    {
//                        config.SignIn.RequireConfirmedEmail = true;
//                        config.User.RequireUniqueEmail = true;
//                    })
//                    .AddEntityFrameworkStores<ApplicationDbContext>()
//                    .AddUserManager<ApplicationUserManager>()
//                    .AddDefaultTokenProviders();

//                services.AddTransient<IEmailSender, EmailSender>();
//                services.Configure<AuthMessageSenderOptions>(context.Configuration);
//            });
//        }
//    }
//}