using Inline.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inline.API.Data
{
    public class InlineDbContext : DbContext
    {
        public InlineDbContext(DbContextOptions<InlineDbContext> options) : base(options) { }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

    }
}
