using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Shared.Domain
{
    public class Order: BaseDomainModel
    {
        public string? TransactionType { get; set; }
        public double Price { get; set;}
        public int GameId { get; set;}
        public virtual Game? Game { get; set; }
    }
}
