using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.DAL.Models
{
    public class Transaction: BaseEntity
    {
        public StatusTransaction Status { get; set; }
        public Types Type { get; set; }
        public string ClientName { get; set; }
        public double Amount { get; set; }
    }
}
