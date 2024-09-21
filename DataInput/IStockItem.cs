namespace CutCraftEngineData.DataInput
{
    public interface IStockItem : IDataGroupRoot
    {
        string description { get; set; } 
        Edging edging { get; set; } 
        int id { get; set; } 
        string identifier { get; set; } 
        double length { get; set; } 
        int materialId { get; set; } 
        string priority { get; set; } 
        int quantity { get; set; } 
        string structure { get; set; } 
        double width { get; set; } 

        dynamic SizeReal();
    }
}