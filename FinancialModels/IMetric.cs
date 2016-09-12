using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public interface IMetric
    {
        string Name { get; set; }
        int Amount { get; set; }

        ITimePeriod TimePeriod { get; set; }
    }
}
