using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    public class GatherVeneer : IDataInputCollectorAppend
    {

        public IVeneer Add<IVeneer>(IVeneer veneer)
        {
            return veneer;
        }
    }
}
