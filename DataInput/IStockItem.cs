namespace CutCraftEngineDataInput.DataInput
{
    public interface IStockItem : IDataGroupRoot
    {
        string description { get; }
        Edging edging { get; }
        int id { get; }
        string identifier { get; }
        double length { get; }
        int materialId { get; }
        string priority { get; }
        int quantity { get; }
        string structure { get; }
        double width { get; }

        dynamic SizeReal();
    }
}