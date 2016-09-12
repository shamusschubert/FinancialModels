using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public class FinancialModel : IFinancialModel
    {
        private List<IAsset> _assets;
        private List<IExpense> _expenses;
        private List<ILiability> _liabilties;
        private List<IRevenue> _revenues;


        public FinancialModel()
        {
            _assets = new List<IAsset>();
            _assets.Add(new Asset { Amount = 100 });
            _assets.Add(new Asset { Amount = 100 });
            _assets.Add(new Asset { Amount = 100 });
            _assets.Add(new Asset { Amount = 100 });
            _assets.Add(new Asset { Amount = 100 });
            _assets.Add(new Asset { Amount = 100 });
            _assets.Add(new Asset { Amount = 100 });

            _liabilties = new List<ILiability>();
            _liabilties.Add(new Liability { Amount=   90 });
            _liabilties.Add(new Liability { Amount = 90 });
            _liabilties.Add(new Liability { Amount = 90 });
            _liabilties.Add(new Liability { Amount = 90 });
            _liabilties.Add(new Liability { Amount = 90 });
            _liabilties.Add(new Liability { Amount = 90 });
            _liabilties.Add(new Liability { Amount = 90 });
        }

        public IEnumerable<IAsset> Assets
        {
            get
            {
                return _assets;
            }
            set
            {
                _assets = value.ToList();
            }
        }

        public IEnumerable<IExpense> Expenses
        {
            get
            {
                return _expenses;
            }
            set
            {
                _expenses = value.ToList();
            }
        }

        public IEnumerable<ILiability> Liabilities
        {
            get
            {
                return _liabilties;
            }
            set
            {
                _liabilties = value.ToList();
            }
        }

        public IEnumerable<IRevenue> Revenue
        {
            get
            {
                return _revenues;
            }
            set
            {
                _revenues = value.ToList();
            }
        }
    }
}
