namespace PlasticisingTile.Core.Models.DynamicQuery;
public class DynamicQuerySelection
{
    public DynamicQuerySelection(string leftOperandAttributeKey)
    {
        LeftOperandAttributeKey = leftOperandAttributeKey;
    }

    public string LeftOperandAttributeKey { get; set; }
    public SelectionOperationEnum Operation { get; set; }
    public object? RightOperandValue { get; set; }
}
