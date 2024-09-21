
namespace CutCraftEngineData.DataInput
{
    public interface IMaterial : IDataGroupRoot
    {
        bool allowEdgeCuts { get; set; } 
        bool canBeVeneered { get; set; } 
        bool canHaveStructure { get; set; } 
        bool canMirror { get; set; } 
        bool canRotate { get; set; } 
        string cuttingDimensions { get; set; } 
        int defaultEdging { get; set; } 
        int deviceId { get; set; } 
        int id { get; set; } 
        double kerf { get; set; } 
        string kind { get; set; } 
        int margin { get; set; } 
        bool marginEditable { get; set; } 
        ReuseWaste rauseWaste { get; set; } 
        List<StandardStockItem> standardStockItems { get; set; } 
        int surplus { get; set; } 
        bool surplusEditable { get; set; } 
        int thickness { get; set; } 
        string title { get; set; } 
        int width { get; set; } 
    }
}