using Microsoft.EntityFrameworkCore;

namespace LearnIdentityFramework.Database
{
    public class IdentityDb : DbContext
    {
        public IdentityDb(DbContextOptions options):base(options) { }
    }
}
