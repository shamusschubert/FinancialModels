using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    // Non monetary metrics, such as 'stores' or 'subscribers' or other important relative measure to be compared to financial figures.
    public interface IMetric
    {
        string Name { get; set; }
        int Amount { get; set; }

        ITimePeriod TimePeriod { get; set; }
    }
}
