﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.FirstMethod
{
    public interface IAveragingMethod
    {
        double Calculate(IEnumerable<double> values);
    }
}
