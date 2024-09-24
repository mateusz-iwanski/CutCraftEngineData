using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataOutput
{
    public class Statistics
    {
        [JsonProperty("2d")]
        public Statistics2d _2d { get; set; }
        [JsonProperty("1d")]
        public Statistics1d _1d { get; set; }

        /// <summary>
        /// Parameterless constructor to avoid using a logical 
        /// constructor during deserialization
        /// </summary>
        public Statistics() { }

        public Statistics(JToken jToken)
        {
            _2d = new Statistics2d(jToken["2d"]);
            _1d = new Statistics1d(jToken["1d"]);
        }
    }
}
