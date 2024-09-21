namespace CutCraftEngineData.DataInput
{
    public interface IVeneer : IDataGroupRoot
    {
        int id { get; set; } 
        double maxMaterialThickness { get; set; } 
        double thickness { get; set; } 
        string title { get; set; } 
        int width { get; set; } 
    }
}