using FundRaisers.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FundRaisers.Data;

public class FundRaisersDbContext : IdentityDbContext<FundRaisersUser>
{
    public FundRaisersDbContext(DbContextOptions<FundRaisersDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
       
    }
    public DbSet<FundRaisers.Models.Donor> Donors { get; set; }
    public DbSet<FundRaisers.Models.Event> Events { get; set; }

}
