using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicTacToe.Web.Areas.Identity.Data;

namespace TicTacToe.Web.Areas.Identity.Data;

public class TicTacToeWebContext : IdentityDbContext<User>
{
    public TicTacToeWebContext(DbContextOptions<TicTacToeWebContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new AplicationUserEntity());
    }
}

