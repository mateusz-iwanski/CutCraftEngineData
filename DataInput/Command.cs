using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    /// <summary>
    /// DataInput from the client to the websocket server
    /// </summary>
    public class Command : DataGroupInput
    {
        public int Id { get; init; }
        public string Cmd { get; init; }
        public Configuration.Configuration Configuration { get; init; }
        public DataInput Input { get; init; } 

        public Command()
        {
            return;
        }

    }

}
