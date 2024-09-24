using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataOutput
{
    /// <summary>
    /// Represents the statistics for a cutting object.
    /// </summary>
    public class CuttingStatistics
    {
        [JsonProperty("1d")]
        public CuttingStatistics1d _1d { get; set; }

        [JsonProperty("2d")]
        public CuttingStatistics2d _2d { get; set; }

        /// <summary>
        /// Parameterless constructor to avoid using a logical 
        /// constructor during deserialization
        /// </summary>
        public CuttingStatistics() { }
        public CuttingStatistics(JToken jToken)
        {
            // this._1d = new CuttingStatistics1d(jToken["1d"]);
            _2d = new CuttingStatistics2d(jToken["2d"]);
        }
    }
}
