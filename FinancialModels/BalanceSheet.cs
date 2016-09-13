using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public class BalanceSheet : IBalanceSheet
    {
        public double NetWorth(IFinancialModel Model)
        {
            return (Model.Assets.Sum(m => m.Amount) - Model.Liabilities.Sum(m => m.Amount));
        }

        public double TotalAssets(IFinancialModel Model)
        {
            return (Model.Assets.Sum(m => m.Amount));
        }

        public double TotalLiabilities(IFinancialModel Model)
        {
            return (Model.Liabilities.Sum(m => m.Amount));
        }
    }
}
