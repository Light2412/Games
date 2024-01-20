using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Shared.Domain
{
    public class Game: BaseDomainModel
    {
        public string? Title { get; set; }
        public string? AgeGroup { get; set; }
        public string? Description { get; set; }
        public string? Genre { get; set;}
        public double Price { get; set; }
    }
}
