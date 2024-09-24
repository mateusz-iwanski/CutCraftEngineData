using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CutCraftEngineData.DataOutput
{
    /// <summary>
    /// Represents a cutting object.
    /// </summary>
    public class Cutting
    {
        /// <summary>
        /// ID of the StockItem for which this cut is made.
        /// </summary>
        public int stockItemId { get; set; }

        /// <summary>
        /// If stack cutting is enabled for the material, it indicates the number of stacks the cutting should be performed for. 
        /// Otherwise, it indicates the number of times the cutting should be performed.
        /// The meaning of the quantity property varies depending on whether stack cutting is enabled or disabled.
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// Statistics of the entire cutting.
        /// </summary>
        public CuttingStatistics statistics { get; set; }

        /// <summary>
        /// A list of all pieces placed on the cutting, including their positions and transformations.
        /// </summary>
        public List<CuttingPiece> pieces { get; set; }

        /// <summary>
        /// A list of all Waste items, including their positions and sizes.
        /// </summary>
        public List<CuttingRest> rest { get; set; }

        /// <summary>
        /// A list of Cut objects.
        /// </summary>
        public List<Cut> cuts { get; set; }

        /// <summary>
        /// Parameterless constructor to avoid using a logical 
        /// constructor during deserialization
        /// </summary>
        public Cutting() { }

        // TODO: change JToken to JObject, we know what it will be
        public Cutting(JToken jToken)
        {

            stockItemId = (int)jToken["stockItemId"];
            quantity = (int)jToken["quantity"];
            pieces = new List<CuttingPiece>();
            rest = new List<CuttingRest>();
            cuts = new List<Cut>();
            statistics = new CuttingStatistics(jToken["statistics"]);

            foreach (JToken piece in jToken["pieces"])
                pieces.Add(new CuttingPiece(piece));

            foreach (JToken _rest in jToken["rest"])
                rest.Add(new CuttingRest(_rest));

            foreach (JToken cut in jToken["cuts"])
                cuts.Add(new Cut(cut));



        }
    }
}
