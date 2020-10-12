using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.BLL.DTO;
using TestApp.DAL.Abstract;
using TestApp.DAL.Models;

namespace TestApp.BLL.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IRepository<Transaction> _repository;
        public TransactionService(IRepository<Transaction> repository)
        {
            this._repository = repository;
        }
        public async Task CreateTransaction(Transaction transaction)
        {
            if (transaction == null) throw new Exception("You can`t create empty transaction");
            else await _repository.Create(transaction);
        }

        public async Task DeleteTransaction(int id)
        {
            if (await _repository.Get(id).ConfigureAwait(false) == null)
            {
                throw new Exception($"Not found transaction with id={id}");
            }
            else
            {
                await _repository.Delete(id);
            }
        }

        public async Task EditTransaction(Transaction transaction)
        {
            if (await _repository.Get(transaction.Id) == null)
            {
                throw new Exception($"Not found transaction with id={transaction.Id}");
            }
            else
            {
                var projectEntity = await _repository.Get(transaction.Id);
                await _repository.Update(projectEntity);
            }
        }

        public async Task<Transaction> GetTransactionById(int id)
        {
            if (await _repository.Get(id)== null) throw new Exception($"Not found transaction with id={id}");
            else return await _repository.Get(id);
        }

        public async Task<List<Transaction>> GetTransactions()
        {
            return await _repository.Get();
        }
    }
}
