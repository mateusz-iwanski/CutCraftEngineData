﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineDataInput.DataInput
{
    internal class MaterialTemplate
    {        
        public static Material MaterialFurnitureMelamineBoard(int id, int deviceId, string title, int thickness, double kerf,
            ReuseWaste rauseWaste, List<StandardStockItem> standardStockItems)
        { 
            return new Material(
                id: id,
                deviceId: deviceId,
                title: title,
                kind: "2d",
                width: 0,
                thickness: thickness,
                canHaveStructure: true,
                canRotate: false,
                canMirror: false,
                surplus: 0,
                surplusEditable: true,  // surplus set in _piece 
                margin: 0,
                marginEditable: true,  // Margin set in _piece
                defaultEdging: 0,
                cuttingDimensions: "net",
                canBeVeneered:false,
                kerf: kerf,
                allowEdgeCuts: true,
                rauseWaste: rauseWaste,
                standardStockItems: standardStockItems
                );
        }
    }
}
