using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public interface IFinancialModel
    {
        IInstrument Instrument { get; set; }

        IEnumerable<IExpense> Expenses { get; set; }
        IEnumerable<IRevenue> Revenue { get; set; }
        IEnumerable<IAsset> Assets { get; set; }
        IEnumerable<ILiability> Liabilities { get; set; }

        IEnumerable<IMetric> Metrics { get; set; }  // non financial measures such as stores or customers

        void AddExpense(IExpense Expense);
        void AddRevenue(IRevenue Revenue);
        void AddAsset(IAsset Asset);
        void AddLiability(ILiability Liability);
        void AddMetric(IMetric Metric);
    }
}
