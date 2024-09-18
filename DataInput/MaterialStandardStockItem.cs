using CutCraftEngineData.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutCraftEngineData.DataInput
{
    /// <summary>
    /// The StandardStockItem object is used to define standard dimensions and default characteristics of stock items.
    /// </summary>
    public class StandardStockItem
    {
        /// <summary>
        /// Unique id of a StandardStockItem.
        /// </summary>
        public required int id { get; init; }

        /// <summary>
        /// Title of a StandardStockItem.
        /// </summary>
        public required string title { get; init;  }

        /// <summary>
        /// Length of a StandardStockItem.
        /// </summary>
        public required int length { get; init;  }

        /// <summary>
        /// Width of a StandardStockItem.
        /// </summary>
        public int width { get; init; }

        /// <summary>
        /// Specifies acceptable structures of the _piece. Allowed values: none, byLength, byWidth.
        /// Allowed values
        ///     - none
        ///         The material has no structure. Is not good idea to use it, if set none optimalization not rotate the _piece.
        ///         Is better to use
        ///     - byLength
        ///         The structure is horizontal (along length).
        ///     - byWidth
        ///         The structure is vertical (along width).
        ///     - "none,byLength,byWidth" = The material has no structure or with structure but can be rotate.
        ///       With this settings the _piece will can be rotated by optimalization.
        ///     - any
        /// </summary>
        [StringValueAssignable("none", "byLength", "byWidth", "none,byLength,byWidth")]
        public string structure { get; init; }

        /// <summary>
        /// Edging configuration.
        /// </summary>
        public Edging edging { get; init; }

        public StandardStockItem(int id, string title, int length, int width, string structure, Edging edging)
        {
            this.id = id;
            this.title = title;
            this.length = length;
            this.width = width;
            this.structure = structure;
            this.edging = edging;
        }
    }
}
