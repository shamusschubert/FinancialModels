using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public class TimePeriod : ITimePeriod
    {
        private int _year;
        private string _quarter;

        public string Quarter
        {
            get
            {
                return _quarter;
            }

            set
            {
                _quarter = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }

        //public enum QuarterTypes
        //{
        //    Q1,Q2,Q3,Q4,FY,CY
        //}
    }
}
