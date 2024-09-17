using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDataInputCollectorAppend
    {
        public T Add<T>(T dataGroupRoot);
    }
}
