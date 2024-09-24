using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CutCraftEngineData.DefaultUnits;

namespace CutCraftEngineData.DataOutput
{
    /// <summary>
    /// Output data group contains optimization results.
    /// </summary>
    public class DataOutputs
    {
        /// <summary>
        /// Version number of the data group.
        /// </summary>
        public string version;

        /// <summary>
        /// Default units specification as described in defaultUnits section.
        /// </summary>
        public DefaultUnits.DefaultUnits defaultUnits;

        /// <summary>
        /// Global statistics of the entire optimization.
        /// </summary>
        public Statistics statistics;

        /// <summary>
        /// List of cutting objects.
        /// </summary>
        public List<Cutting> cuttings;

        /// <summary>
        /// Parameterless constructor to avoid using a logical 
        /// constructor during deserialization
        /// </summary>
        public DataOutputs() { }

        /// <summary>
        /// Initializes a new instance of the class. JObject is a Object from Newtonsoft.Json.
        /// In such a nested structure of object we can't use JsonConvert.DeserializeObject
        /// </summary>
        /// <param name="jobject">Newtonsoft.Json JObject</param>        
        public DataOutputs(JObject jobject)
        {
            version = jobject["version"].ToString();
            defaultUnits = new DefaultUnits.DefaultUnits(jobject["defaultUnits"]);
            statistics = new Statistics(jobject["statistics"]);
            cuttings = new List<Cutting>();

            foreach (JToken cutting in jobject["cuttings"])
                cuttings.Add(new Cutting(cutting));
        }
    }
}
