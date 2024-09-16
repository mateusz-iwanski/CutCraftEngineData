using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    public class DataInputCollector<T>
    {
        List<T> DataInputObjects;
        IDataInputCollectorAppend _IDataInputCollectorAppend;

        public DataInputCollector(IDataInputCollectorAppend iDataInputCollectorAppend)
        {
            this.DataInputObjects = new List<T> { };
            this._IDataInputCollectorAppend = iDataInputCollectorAppend;
        }

        public void Append(T dataGroupObject)
        {
            this.DataInputObjects.Add(this._IDataInputCollectorAppend.Add<T>(dataGroupObject));
        }

        public List<T> GetObjectList() => this.DataInputObjects;
    }
}
