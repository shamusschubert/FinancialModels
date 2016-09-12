using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialModels
{
    public class Test
    {
        public Test()
        {
            FinancialModel model = new FinancialModel();

            model.AddAsset(new Asset { Amount = 500 });
            model.AddAsset(new Asset { Amount = 600 });
            model.AddAsset(new Asset { Amount = 700 });
            model.AddAsset(new Asset { Amount = 800 });
            model.AddAsset(new Asset { Amount = 900 });

            model.AddLiability(new Liability { Amount = 400 });
            model.AddLiability(new Liability { Amount = 500 });
            model.AddLiability(new Liability { Amount = 600 });
            model.AddLiability(new Liability { Amount = 700 });
            model.AddLiability(new Liability { Amount = 800 });

        }
    }
}
