using CutCraftEngineData.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    /// <summary>
    /// DataInput from the client to the websocket server
    /// </summary>
    public class Command : DataGroupInput
    {
        public int id { get; init; }

        /// <summary>
        /// Command name sent from the client
        /// </summary>
        [JsonProperty("cmd")]
        public CommandName Cmd { get; init; }

        /// <summary>
        /// Config data group contains just a list of profiles to be used.
        /// </summary>
        [JsonProperty("config")]
        public Configuration.Configuration Config { get; init; }

        /// <summary>
        /// Input data group contains input data from the client.
        /// </summary>
        [JsonProperty("input")]
        public DataInput Input { get; init; }

        /// <summary>
        /// The allowOverstock parameter controls the behavior of the cutting optimization algorithm. 
        /// When set to true, the algorithm is permitted to allocate more stock items than currently available. 
        /// This can be useful in scenarios where future stock replenishment is anticipated or over-allocation is acceptable. 
        /// Please note that enabling this option may lead to situations where demand exceeds supply.
        /// Note that it applies only to standard stock sizes.So, in order to use more stock items than available, 
        /// you have to define standard stock items in material definition.
        /// Then, you have to add stock item with the same standard size.
        /// </summary>
        [JsonProperty("allowOverstock")]
        public bool AllowOverstock { get; init; }
        
        public Command()
        {
            return;
        }
    }

}
