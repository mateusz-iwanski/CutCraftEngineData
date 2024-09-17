using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput 
{
    internal class GatherPiece : IDataInputCollectorAppend
    {
        public IPiece Add<IPiece>(IPiece piece)
        {
            return piece;
        }
    }
}
