using System;
using HrUserPortal.Areas.Identity.Data;
using HrUserPortal.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(HrUserPortal.Areas.Identity.IdentityHostingStartup))]
namespace HrUserPortal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<HrUserPortalDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("HrUserPortalDBContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<HrUserPortalDBContext>();
            });
        }
    }
}