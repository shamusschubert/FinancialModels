﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public interface IBalanceSheet
    {
        double TotalAssets(IFinancialModel Model);
        double TotalLiabilities(IFinancialModel Model);
        double NetWorth(IFinancialModel Model);
    }
}
