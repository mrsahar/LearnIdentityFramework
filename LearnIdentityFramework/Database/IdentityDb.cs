using LearnIdentityFramework.Areas.Identity.Data;
using LearnIdentityFramework.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnIdentityFramework.Database
{
    public class IdentityDb : IdentityDbContext<LearnIdentityFrameworkUsers>
    {
        public IdentityDb(DbContextOptions<IdentityDb> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AddEnitityConfigration());
        }
         
    }

    public class AddEnitityConfigration : IEntityTypeConfiguration<LearnIdentityFrameworkUsers>
    {
        public void Configure(EntityTypeBuilder<LearnIdentityFrameworkUsers> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(225);
            builder.Property(x => x.LastName).HasMaxLength(225);
    }
    }
} 