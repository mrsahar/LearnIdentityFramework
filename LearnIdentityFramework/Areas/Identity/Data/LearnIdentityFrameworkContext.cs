using LearnIdentityFramework.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearnIdentityFramework.Areas.Identity.Data;

public class LearnIdentityFrameworkContext : IdentityDbContext<LearnIdentityFrameworkUsers>
{
    public LearnIdentityFrameworkContext(DbContextOptions<LearnIdentityFrameworkContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
