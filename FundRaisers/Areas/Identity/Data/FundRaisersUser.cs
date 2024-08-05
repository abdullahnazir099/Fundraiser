using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FundRaisers.Areas.Identity.Data;

// Add profile data for application users by adding properties to the FundRaisersUser class
public class FundRaisersUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? City { get; set; }
}

