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


            List<Asset> assets = new List<Asset>();

            model.Assets = assets;


            foreach(var asset in model.Assets)
            {
                Console.WriteLine(asset.Amount);
            }

            foreach (var lib in model.Liabilities)
            {
                Console.WriteLine(lib.Amount);
            }

        }
    }
}
