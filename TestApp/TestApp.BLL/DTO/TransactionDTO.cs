using TestApp.DAL.Models;

namespace TestApp.BLL.DTO
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        public StatusTransaction Status { get; set; }
        public Types Type { get; set; }
        public string ClientName { get; set; }
        public decimal Amount { get; set; }
    }
}
