namespace CutCraftEngineDataInput.DataInput
{
    public interface IPiece : IDataGroupRoot
    {
        string description { get; }
        int id { get; }
        string identifier { get; }
        int length { get; }
        int margin { get; }
        int materialId { get; }
        string priority { get; }
        int quantity { get; }
        string shapeType { get; }
        string structure { get; }
        int surplus { get; }
        Veneers veneers { get; set; }
        int width { get; }

        dynamic SizeReal();
    }
}