using Microsoft.EntityFrameworkCore;
using Ubee.Domain.Entities;

namespace Ubee.Data.Contexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = "Server=localhost; Database=UbeeDb; User Id=postgres; password=jama1226";
        optionsBuilder.UseNpgsql(path);
    }

    public virtual DbSet<User> Users { get; set; }
    public  virtual DbSet<Wallet> Wallets { get; set; }
    public virtual DbSet<Transaction> Transactions { get; set; }
    public virtual DbSet<Info> Infos { get; set; }
}
