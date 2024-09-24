﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataOutput
{
    /// <summary>
    /// Represents the statistics for 1D cutting if the material type is 1D.
    /// </summary>
    public class Statistics1d
    {
        /// <summary>
        /// The total length of all used stock items.
        /// </summary>
        public double length { get; set; }

        /// <summary>
        /// The total length of all used pieces.
        /// </summary>
        public double usedLength { get; set; }

        /// <summary>
        /// The total waste length.
        /// </summary>
        public double wasteLength { get; set; }

        /// <summary>
        /// The total length of usable waste.
        /// </summary>
        public double unusedLength { get; set; }

        /// <summary>
        /// The number of cuts.
        /// </summary>
        public int cutCount { get; set; }

        /// <summary>
        /// The total length of all the cuts.
        /// </summary>
        public double cutsLength { get; set; }

        /// <summary>
        /// Parameterless constructor to avoid using a logical 
        /// constructor during deserialization
        /// </summary>
        public Statistics1d() { }

        /// <summary>
        /// Constructor for the OneD class.
        /// </summary>
        /// <param name="length">The total length of all used stock items.</param>
        /// <param name="usedLength">The total length of all used pieces.</param>
        /// <param name="wasteLength">The total waste length.</param>
        /// <param name="unusedLength">The total length of usable waste.</param>
        /// <param name="cutCount">The number of cuts.</param>
        /// <param name="cutsLength">The total length of all the cuts.</param>
        public Statistics1d(double length, double usedLength, double wasteLength, double unusedLength, int cutCount, double cutsLength)
        {
            this.length = length;
            this.usedLength = usedLength;
            this.wasteLength = wasteLength;
            this.unusedLength = unusedLength;
            this.cutCount = cutCount;
            this.cutsLength = cutsLength;
        }

        public Statistics1d(JToken jToken)
        {
            length = (double)jToken["length"];
            usedLength = (double)jToken["usedLength"];
            wasteLength = (double)jToken["wasteLength"];
            unusedLength = (double)jToken["unusedLength"];
            cutCount = (int)jToken["cutCount"];
            cutsLength = (double)jToken["cutsLength"];
        }
    }
}
