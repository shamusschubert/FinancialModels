using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public class Asset : IAsset
    {
        private double _value;

        public double Amount
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }
    }
}
