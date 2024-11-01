﻿using CutCraftEngineData.DataInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.Configuration
{
    /// <summary>
    /// Represents a strategy that shortens optimization time significantly by switching to a "fast route" if a better solution cannot be found within a specified time.
    /// </summary>
    public class DynamicMethodSwitch : DataGroupInput
    {
        /// <summary>
        /// Enables or disables the dynamicMethodSwitch strategy.
        /// </summary>
        public bool enabled { get; set; } 

        /// <summary>
        /// The amount of time during which the program is unable to find a better solution. When this threshold is reached, the optimization will switch to the "fast route".
        /// Use seconds as unit.        
        /// </summary>
        public string threshold { get; set; } 

        /// <summary>
        /// Initializes a new instance of the DynamicMethodSwitch class with the specified enabled flag and time threshold for switching to the "fast route".
        /// </summary>
        /// <param name="enabled">The flag to enable or disable the dynamicMethodSwitch strategy.</param>
        /// <param name="threshold">The amount of time (in seconds, e.g. 1s) threshold for switching to the "fast route". Use seconds as unit.</param>
        public DynamicMethodSwitch(bool enabled, string threshold)
        {
            this.enabled = enabled;
            this.threshold = threshold;
        }
    }
}
