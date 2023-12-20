using Beblio.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Beblio.infrastructure.Data;

public class DBC : DbContext
{
    public DBC()
    {
    }
    public DBC(DbContextOptions<DBC> options)
        : base(options)
    { }

    public DbSet<Users> Users { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<UsersRoles> UserRoles { get; set; }
    public DbContextOptions<DBC> Options { get; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UsersRoles>()
            .HasKey(ur => new { ur.UserID, ur.RoleID });

        modelBuilder.Entity<UsersRoles>()
            .HasOne(ur => ur.User)
            .WithMany(u => u.UserRoles)
            .HasForeignKey(ur => ur.UserID);

        modelBuilder.Entity<UsersRoles>()
            .HasOne(ur => ur.Role)
            .WithMany(r => r.UserRoles)
            .HasForeignKey(ur => ur.RoleID);
    }
}


