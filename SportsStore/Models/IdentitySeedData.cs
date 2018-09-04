using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public static class IdentitySeedData
    {
        private const string AdminUser = "Admin";
        private const string AdminPassword = "Secret123$";

        public static async Task EnsurePopulated(UserManager<IdentityUser> userManager)
        {
            var user = await userManager.FindByIdAsync(AdminUser);
            if (user == null)
            {
                user = new IdentityUser("Admin");
                await userManager.CreateAsync(user, AdminPassword);
            }
        }
    }
}