﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public interface ITimePeriod
    {
        int Year { get; set; }
        string Quarter { get; set; }
    }
}
