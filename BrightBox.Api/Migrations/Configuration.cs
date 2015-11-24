using BrightBox.Api.Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BrightBox.Api.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Api.Infrastructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BrightBox.Api.Infrastructure.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ApplicationDbContext.Create()));
            var user = new ApplicationUser
            {
                UserName = "admin",
                Email = "mihkop@gmail.com",
                EmailConfirmed = true,
                FirstName = "Mikhail",
                LastName = "Kopchenin",
            };
            manager.Create(user, "admin");
        }
    }
}
