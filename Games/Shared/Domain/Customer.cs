using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Shared.Domain
{
    public class Customer: BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Password { get; set; }
        public string? ContactNumber { get; set; }
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }

    }
}
