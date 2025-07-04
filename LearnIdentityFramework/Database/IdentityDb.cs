using LearnIdentityFramework.Areas.Identity.Data;
using LearnIdentityFramework.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace LearnIdentityFramework.Database
{
    public class IdentityDb : IdentityDbContext<LearnIdentityFrameworkUsers>
    {
        public IdentityDb(DbContextOptions<IdentityDb> options):base(options) { }
        public DbSet<Student> Students { get; set; }
    }
 


}
