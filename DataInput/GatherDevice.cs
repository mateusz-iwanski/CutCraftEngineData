using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    internal class GatherDevice : IDataInputCollectorAppend
    {
        public IDevice Add<IDevice>(IDevice device)
        {
            return device;
        }
    }
}
