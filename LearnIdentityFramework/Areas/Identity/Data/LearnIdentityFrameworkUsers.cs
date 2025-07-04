using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LearnIdentityFramework.Areas.Identity.Data;

// Add profile data for application users by adding properties to the LearnIdentityFrameworkUsers class
public class LearnIdentityFrameworkUsers : IdentityUser
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}

