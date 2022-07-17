using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SharedKernel.Constants;

namespace Infrastructure.Identity
{
    public  class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(AppIdentityDbContext identityDbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (identityDbContext.Database.IsSqlServer())
            {
                identityDbContext.Database.Migrate();
            }

            await roleManager.CreateAsync(new IdentityRole(Roles.ADMINISTRATORS));

            var defaultUser = new ApplicationUser { UserName = "vodanggia1", Email = "doinhulon111@gmail.com" };
            await userManager.CreateAsync(defaultUser, "Pass@word1");

            var adminUser = new ApplicationUser { UserName = "admin", Email = "admin@gmail.com" };
            await userManager.CreateAsync(adminUser, "Pass@word1");
            adminUser = await userManager.FindByNameAsync("admin");
            await userManager.AddToRoleAsync(adminUser, Roles.ADMINISTRATORS);
        }
    }
}
