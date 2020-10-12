using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestApp.DAL.Models;

namespace TestApp.DAL.Repository
{
    public class TransactionContext: DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options) : base(options) { }

        DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var transactions = new List<Transaction>()
            {
                new Transaction{ Id=1, Status=StatusTransaction.Pending, Type = Types.Refill, ClientName="Ann Taylor", Amount=100},
                new Transaction{Id=2, Status=StatusTransaction.Cancelled, Type=Types.Refill, ClientName="Bill Crash", Amount=300},
                new Transaction{Id=3, Status=StatusTransaction.Completed, Type=Types.Withdrawal, ClientName="Brian May", Amount=9957}
            };
            modelBuilder.Entity<Transaction>().HasData(transactions);
            base.OnModelCreating(modelBuilder);
        }
    }
}
