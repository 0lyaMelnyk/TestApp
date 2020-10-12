using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.BLL.DTO;
using TestApp.DAL.Models;

namespace TestApp
{
    public interface ITransactionService
    {
        Task<List<Transaction>> GetTransactions();
        Task<Transaction> GetTransactionById(int id);
        Task EditTransaction(int id);
        Task DeleteTransaction(int id);
        Task CreateTransaction(Transaction transaction);
    }
}
