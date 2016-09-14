using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public class Expense : IExpense
    {
        private double _amount;
        private ITimePeriod _timePeriod;
        private string _nothing;

        public double Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
            }
        }

        public ITimePeriod TimePeriod
        {
            get
            {
                return _timePeriod;
            }

            set
            {
                _timePeriod = value;
            }
        }
    }
}
