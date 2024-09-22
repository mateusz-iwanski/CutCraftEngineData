﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataOutput
{
    public class Cut
    {
        /// <summary>
        /// Start X position of the cut.
        /// </summary>
        /// <param name="startX">Start X position of the cut.</param>
        public double startX { get; set; }

        /// <summary>
        /// Start Y position of the cut.
        /// </summary>
        /// <param name="startY">Start Y position of the cut.</param>
        public double startY { get; set; }

        /// <summary>
        /// End X position of the cut.
        /// </summary>
        /// <param name="endX">End X position of the cut.</param>
        public double endX { get; set; }

        /// <summary>
        /// End Y position of the cut.
        /// </summary>
        /// <param name="endY">End Y position of the cut.</param>
        public double endY { get; set; }

        /// <summary>
        /// Parameterless constructor to avoid using a logical 
        /// constructor during deserialization
        /// </summary>
        public Cut() { }

        /// <summary>
        /// Constructor for Cut class.
        /// </summary>
        /// <param name="startX">Start X position of the cut.</param>
        /// <param name="startY">Start Y position of the cut.</param>
        /// <param name="endX">End X position of the cut.</param>
        /// <param name="endY">End Y position of the cut.</param>
        public Cut(double startX, double startY, double endX, double endY)
        {
            this.startX = startX;
            this.startY = startY;
            this.endX = endX;
            this.endY = endY;
        }

        public Cut(JToken jToken)
        {
            startX = (double)jToken["startX"];
            startY = (double)jToken["startY"];
            endX = (double)jToken["endX"];
            endY = (double)jToken["endY"];

        }
    }
}
