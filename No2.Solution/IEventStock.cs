﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public interface IEventStock
    {
        event EventHandler<StockInfo> eventStock;
    }
}
