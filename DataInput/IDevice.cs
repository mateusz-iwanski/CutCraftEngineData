namespace CutCraftEngineData.DataInput
{
    public interface IDevice : IDataGroupRoot
    {
        bool canCrossCuts { get; set; } 
        string edgingCuts { get; set; } 
        string firstCutDirection { get; set; } 
        bool fullCutsOnly { get; set; } 
        int id { get; set; } 
        string materialKind { get; set; } 
        MaxCutDepth maxCutDepth { get; set; }
        MaxCutLengthByLength maxCutLengthByLength { get; set; } 
        MaxCutLengthByWidth maxCutLengthByWidth { get; set; } 
        int minCutWidth { get; set; } 
        string originEdgingCuts { get; set; } 
        Slants slants { get; set; } 
        bool stripCuts { get; set; } 
        string title { get; set; } 
        public int MaxLayoutSize { get; set; } 
    }
}