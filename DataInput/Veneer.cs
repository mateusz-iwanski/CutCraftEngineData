using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    /// <summary>
    /// List of veneer objects.
    /// </summary>
    /// <summary>
    /// The Veneer object specifies characteristics of a veneer.
    /// </summary>
    public class Veneer : DataGroupInput, IVeneer
    {
        /// <summary>
        /// Unique id of the veneer.
        /// Mandatory
        /// </summary>
        public int id { get; set; } 

        /// <summary>
        /// Title of the veneer.
        /// Mandatory
        /// </summary>
        public string title { get; set; } 

        /// <summary>
        /// width of the veneer.
        /// Mandatory
        /// </summary>
        public int width { get; set; } 

        /// <summary>
        /// Thickness of the veneer.
        /// Mandatory
        /// </summary>
        public double thickness { get; set; } 

        /// <summary>
        /// The maximum thickness of the material for which this veneer can be used.
        /// Mandatory
        /// </summary>
        public double maxMaterialThickness { get; set; } 

        /// <summary>
        /// Creates a new Veneer object.
        /// </summary>
        /// <param name="id">Unique id of the veneer. Mandatory.</param>
        /// <param name="title">Title of the veneer. Mandatory.</param>
        /// <param name="width">width of the veneer. Mandatory.</param>
        /// <param name="thickness">Thickness of the veneer. Mandatory.</param>
        /// <param name="maxMaterialThickness">The maximum thickness of the material for which this veneer can be used. Mandatory.</param>
        public Veneer(int id, string title, int width, double thickness, double maxMaterialThickness)
        {
            this.id = id;
            this.title = title;
            this.width = width;
            this.thickness = thickness;
            this.maxMaterialThickness = maxMaterialThickness;
        }
    }
}
