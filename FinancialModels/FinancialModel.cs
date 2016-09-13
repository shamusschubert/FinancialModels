using System;
using System.Collections.Generic;
using System.Linq;

namespace FinancialModels
{
    public class FinancialModel : IFinancialModel
    {
        private List<IAsset> _assets;
        private List<IExpense> _expenses;
        private List<ILiability> _liabilties;
        private List<IRevenue> _revenues;
        private List<IMetric> _metrics;
        private IInstrument _instrument;

        public FinancialModel()
        {
            _assets = new List<IAsset>();
            _expenses = new List<IExpense>();
            _liabilties = new List<ILiability>();
            _revenues = new List<IRevenue>();
            _metrics = new List<IMetric>();
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

        public IInstrument Instrument
        {
            get
            {
                return _instrument;
            }
            set
            {
                _instrument = value;
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

        public IEnumerable<IMetric> Metrics
        {
            get
            {
                return _metrics;
            }

            set
            {
                _metrics = value.ToList();
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

        public void AddAsset(IAsset Asset)
        {
            this._assets.Add(Asset);
        }

        public void AddExpense(IExpense Expense)
        {
            this._expenses.Add(Expense);
        }

        public void AddLiability(ILiability Liability)
        {
            this._liabilties.Add(Liability);
        }

        public void AddRevenue(IRevenue Revenue)
        {
            this._revenues.Add(Revenue);
        }

        public void AddMetric(IMetric Metric)
        {
            this._metrics.Add(Metric);
        }

        public void RemoveExpense(IExpense Expense)
        {
            throw new NotImplementedException();
        }

        public void RemoveRevenue(IRevenue Revenue)
        {
            throw new NotImplementedException();
        }

        public void RemoveAsset(IAsset Asset)
        {
            throw new NotImplementedException();
        }

        public void RemoveLiability(ILiability Liability)
        {
            throw new NotImplementedException();
        }

        public void RemoveMetric(IMetric Metric)
        {
            throw new NotImplementedException();
        }
    }
}
