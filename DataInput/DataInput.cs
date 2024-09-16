using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    public class DataInput : DataGroupInput
    {
        public int version { get; }
        public DefaultUnitsInput defaultUnits { get; set; }
        public List<IDevice> devices { get; set;  }
        public List<IMaterial> materials { get; set;  }
        public List<IPiece> pieces { get; set; }
        public List<IStockItem> stock { get; set; }
        public List<IVeneer> veneers { get; set; }

        public DataInput(
            int version, DefaultUnitsInput defaultUnits,
            DataInputCollector<IMaterial> materials,
            DataInputCollector<IDevice> devices,
            DataInputCollector<IPiece> pieces, 
            DataInputCollector<IStockItem> stock, 
            DataInputCollector<IVeneer> veneers)
        {
            this.version = version;
            this.defaultUnits = defaultUnits;
            this.devices = devices.GetObjectList();
            this.materials = materials.GetObjectList();
            this.pieces = pieces.GetObjectList();
            this.stock = stock.GetObjectList();
            this.veneers = veneers.GetObjectList();

            CheckMaterialCompatible(this.pieces, this.stock);
            CheckDeviceCompatible(this.devices, this.materials);
            //CheckPieceSizeWithMaterialSize(this.pieces, this.stock);
        }
    }

    



    
}
