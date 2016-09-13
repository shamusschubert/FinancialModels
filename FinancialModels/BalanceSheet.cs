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
            return (Model.Assets.Sum(m => m.Amount) - Model.Assets.Sum(m => m.Amount));
        }
    }
}
