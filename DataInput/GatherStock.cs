using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    internal class GatherStock : IDataInputCollectorAppend
    {
        public IStockItem Add<IStockItem>(IStockItem stock)
        {
            return stock;
        }
    }
}
