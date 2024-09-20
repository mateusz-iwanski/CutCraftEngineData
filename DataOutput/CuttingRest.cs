using CutCraftEngineData.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataOutput
{
    /// <summary>
    /// The Waste/Rest object describes a waste item.
    /// </summary>
    public class CuttingRest
    {
        /// <value>x position of the waste.</value>
        public double x { get; set; }

        /// <value>y position of the waste.</value>
        public double y { get; set; }

        /// <value>length of the waste.</value>
        public double length { get; set; }

        /// <value>width of the waste.</value>
        public double width { get; set; }

        /// <value>Automatically generated identifier string.</value>
        public string identifier { get; set; }

        /// <value>Specifies whether the waste is usable.</value>
        public bool usable { get; set; }

        /// <value>Type of the shape of the waste.</value>
        [StringValueAssignable("none", "rectangle", "linear")]
        public string shapeType { get; set; }

        /// <value>Depending on shapeType it may contain different Format.</value>
        public object shape { get; set; }

        /// <summary>
        /// Constructor for Waste class.
        /// </summary>
        public CuttingRest(double x, double y, double length, double width, string identifier, bool usable, string shapeType, object shape)
        {
            this.x = x;
            this.y = y;
            this.length = length;
            this.width = width;
            this.identifier = identifier;
            this.usable = usable;
            this.shapeType = shapeType;
            this.shape = shape;
        }

        public CuttingRest(JToken jToken)
        {
            x = (double)jToken["x"];
            y = (double)jToken["y"];
            length = (double)jToken["length"];
            width = (double)jToken["width"];
            identifier = (string)jToken["identifier"];
            usable = (bool)jToken["usable"];
            shapeType = (string)jToken["shapeType"];
            shape = jToken["shape"];
        }
    }
}
