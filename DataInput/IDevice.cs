namespace CutCraftEngineData.DataInput
{
    public interface IDevice : IDataGroupRoot
    {
        bool canCrossCuts { get; }
        string edgingCuts { get; }
        string firstCutDirection { get; }
        bool fullCutsOnly { get; }
        int id { get; }
        string materialKind { get; }
        MaxCutDepth maxCutDepth { get; set; }
        MaxCutLengthByLength maxCutLengthByLength { get; }
        MaxCutLengthByWidth maxCutLengthByWidth { get; }
        int minCutWidth { get; }
        string originEdgingCuts { get; }
        Slants slants { get; }
        bool stripCuts { get; }
        string title { get; }
    }
}