﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public class Test
    {
        public Test()
        {
            FinancialModel model = new FinancialModel();

            model.AddAsset(new Asset { Amount = 500 });
            model.AddAsset(new Asset { Amount = 600 });
            model.AddAsset(new Asset { Amount = 700 });
            model.AddAsset(new Asset { Amount = 800 });
            model.AddAsset(new Asset { Amount = 900 });

            model.AddLiability(new Liability { Amount = 400 });
            model.AddLiability(new Liability { Amount = 500 });
            model.AddLiability(new Liability { Amount = 600 });
            model.AddLiability(new Liability { Amount = 700 });
            model.AddLiability(new Liability { Amount = 800 });

            model.AddExpense(new Expense { Amount = 500, TimePeriod = new TimePeriod { Quarter = "Q1", Year = 2017 } });
            model.AddRevenue(new Revenue { Amount = 600, TimePeriod = new TimePeriod { Quarter = "Q1", Year = 2017 } });

            IBalanceSheet sheet = new BalanceSheet();

            var netWorth = sheet.NetWorth(model);
            var assets = sheet.TotalAssets(model);
            var liabilities = sheet.TotalLiabilities(model);
        }
    }
}