using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FundRaisers.Areas.Identity.Data
{
    public class ApplicationUser: IdentityUser
    {

        [Display(Name = "Full name")]
        public string FullName { get; set; }
    }
}
