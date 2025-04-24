using Microsoft.AspNetCore.Identity;

namespace nomthyApp.Data
{
    public class DbInitializer
    {
        public  async static Task SeedAdmindata(UserManager<ApplicationUser> userManager, ApplicationDbContext applicationDb)
        {
            try
            {

                var createNewUser = new ApplicationUser
                {
                    FirstName = "XXXX",
                    LastName = "XXXX",
                    Email = "xxxx@example.com",
                    NormalizedEmail = "XXXX@EXAMPLE.COM",
                    UserName = "Owner",
                    NormalizedUserName = "OWNER",
                    PhoneNumber = "+111111111111",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error Occured When Trying To Seed Admin Data : {ex.Message}");
            }
        }
    }
}
