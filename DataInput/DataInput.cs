using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    /// <summary>
    /// Input data group contains input data from the client.
    /// </summary>
    public class DataInput : DataGroupInput
    {
        /// <summary>
        /// Version number of the data group.
        /// </summary>
        public int version { get; set; } 

        /// <summary>
        /// The DefaultUnits property specifies the default units for various measurements in the data group. 
        /// </summary>
        public DefaultUnitsInput defaultUnits { get; set; }

        /// <summary>
        /// List of device objects.
        /// </summary>
        public List<Device> devices { get; set;  }

        /// <summary>
        /// List of material objects.
        /// </summary>
        public List<Material> materials { get; set;  }

        /// <summary>
        /// List of pieces objects.
        /// </summary>
        public List<Piece> pieces { get; set; }

        /// <summary>
        /// List of stocks objects.
        /// </summary>
        public List<StockItem> stock { get; set; }

        /// <summary>
        /// List of veneers objects.
        /// </summary>
        public List<Veneer> veneers { get; set; }

        /// <summary>
        /// Parameterless constructor to avoid using a logical 
        /// constructor during deserialization
        /// </summary>
        public DataInput() {}

        public DataInput(
            int version, DefaultUnitsInput defaultUnits,
            DataInputCollector<Material> materials,
            DataInputCollector<Device> devices,
            DataInputCollector<Piece> pieces,
            DataInputCollector<StockItem> stock,
            DataInputCollector<Veneer> veneers)
        {
            this.version = version;
            this.defaultUnits = defaultUnits;
            this.devices = devices.GetObjectList();
            this.materials = materials.GetObjectList();
            this.pieces = pieces.GetObjectList();
            this.stock = stock.GetObjectList();
            this.veneers = veneers.GetObjectList();

            CheckMaterialCompatible(this.pieces, this.stock);
            //CheckDeviceCompatible(this.devices, this.materials);



            //CheckPieceSizeWithMaterialSize(this.pieces, this.stock);
        }
    }

    



    
}
