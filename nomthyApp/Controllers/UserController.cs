using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nomthyApp.Data;

namespace nomthyApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;


        public UserController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            this.dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var userId = userManager.GetUserId(User);
                if (userId == null)
                {
                    Console.WriteLine("User Id Not Found!!!");
                    throw new Exception("User Not Valid");
                }

                var getUser = await dbContext.applicationUsers
                    .ToListAsync();

                return View(getUser);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Occured When Trying To Get User From The Database");
                throw new Exception($"Error Occured When Tring To get Users From The Database : {ex.Message}");
            }
        }
    }
}
