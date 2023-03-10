using huigma.Models;
using Microsoft.EntityFrameworkCore;

namespace huigma.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Folder> Folders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //         folder
        //           |
        //   ------------------
        //   |                |
        //   folder         folder
        //modelBuilder.Entity<Folder>().HasOne<Folder>().WithMany(m => m.ParentFolder).OnDelete(DeleteBehavior.NoAction);
        //modelBuilder.Entity<Folder>().HasMany(m => m.InnerFolders).WithOne().OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }
}
