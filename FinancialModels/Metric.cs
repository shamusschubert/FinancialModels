using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public class Metric : IMetric
    {
        private int _amount;
        private string _name;
        private ITimePeriod _timePeriod; 


        public int Amount
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

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
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
