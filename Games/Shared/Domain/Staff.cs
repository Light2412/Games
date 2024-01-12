using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Shared.Domain
{
    public class Staff: BaseDomainModel
    {
        public int Contact { get; set; }
        public string? Password { get; set; }
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }
    }
}
