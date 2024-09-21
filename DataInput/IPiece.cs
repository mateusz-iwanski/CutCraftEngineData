namespace CutCraftEngineData.DataInput
{
    public interface IPiece : IDataGroupRoot
    {
        string description { get; set; } 
        int id { get; set; } 
        string identifier { get; set; } 
        int length { get; set; } 
        int margin { get; set; } 
        int materialId { get; set; } 
        string priority { get; set; } 
        int quantity { get; set; } 
        string shapeType { get; set; } 
        string structure { get; set; } 
        int surplus { get; set; } 
        Veneers veneers { get; set; }
        int width { get; set; } 

        dynamic SizeReal();
    }
}