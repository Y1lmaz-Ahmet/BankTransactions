using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
	public class TransactionDbContext : DbContext
	{
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {
            
        }
        DbSet<Transaction> Transactions { get; set; }
    }
}
