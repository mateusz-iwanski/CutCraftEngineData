namespace CutCraftEngineData.DataInput
{
    public interface IVeneer : IDataGroupRoot
    {
        int id { get; }
        double maxMaterialThickness { get; }
        double thickness { get; }
        string title { get; }
        int width { get; }
    }
}