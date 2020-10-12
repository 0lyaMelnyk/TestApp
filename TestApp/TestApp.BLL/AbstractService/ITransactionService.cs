using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.DAL.Models;

namespace TestApp
{
    public interface ITransactionService
    {
        List<Transaction> GetTransactions();
        Transaction GetTransactionById(int id);
        void EditTransaction(int id);
        void DeleteTransaction(int id);
        int CreateTransaction();
    }
}
