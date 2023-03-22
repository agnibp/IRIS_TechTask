using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DAL
{
    public class BanksDBContext : DbContext
    {
        public BanksDBContext(DbContextOptions<BanksDBContext> options)
            : base(options)
        {

        }

        public DbSet<BankDetail> BankDetails { get; set; }
    }
}
