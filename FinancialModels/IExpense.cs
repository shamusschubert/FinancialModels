﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public interface IExpense
    {
        ITimePeriod TimePeriod { get; set; }
        double Amount { get; set; }
    }
}
