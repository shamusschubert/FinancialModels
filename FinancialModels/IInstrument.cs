using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public interface IInstrument
    {
        string Symbol { get; set; }
        string Name { get; set; }
        string CUSIP { get; set; }
        int SharesOutstanding { get; set; }
    }
}
