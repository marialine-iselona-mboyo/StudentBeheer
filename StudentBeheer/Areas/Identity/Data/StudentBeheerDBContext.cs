using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentBeheer.Areas.Identity.Data;

namespace StudentBeheer.Data;

public class StudentBeheerDBContext : IdentityDbContext<StudentBeheerUser>
{
    public StudentBeheerDBContext(DbContextOptions<StudentBeheerDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<StudentBeheer.Models.Shop> Shop { get; set; } = default!;

    public DbSet<StudentBeheer.Models.Customer> Customer { get; set; }

}
