using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    internal class GatherMaterial : IDataInputCollectorAppend
    {
        public IMaterial Add<IMaterial>(IMaterial material)
        {
            return material;
        }
    }
}
