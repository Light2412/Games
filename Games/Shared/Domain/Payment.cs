﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Shared.Domain
{
    public class Payment: BaseDomainModel
    {
        public double Price { get; set; }
    }
}
