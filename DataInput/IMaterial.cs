
namespace CutCraftEngineDataInput.DataInput
{
    public interface IMaterial : IDataGroupRoot
    {
        bool allowEdgeCuts { get; }
        bool canBeVeneered { get; }
        bool canHaveStructure { get; }
        bool canMirror { get; }
        bool canRotate { get; }
        string cuttingDimensions { get; }
        int defaultEdging { get; }
        int deviceId { get; }
        int id { get; }
        double kerf { get; }
        string kind { get; }
        int margin { get; }
        bool marginEditable { get; }
        ReuseWaste rauseWaste { get; }
        List<StandardStockItem> standardStockItems { get; }
        int surplus { get; }
        bool surplusEditable { get; }
        int thickness { get; }
        string title { get; }
        int width { get; }
    }
}