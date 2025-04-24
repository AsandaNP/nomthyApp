using Microsoft.AspNetCore.Identity;
using System.Drawing;

namespace nomthyApp.Data
{
    public class ApplicationUser:IdentityUser
    {
        public String FirstName { set; get; }
        public string LastName { set; get; }

        //public string ApproveUser { set; get; } = "Not Approve";
    }
}
