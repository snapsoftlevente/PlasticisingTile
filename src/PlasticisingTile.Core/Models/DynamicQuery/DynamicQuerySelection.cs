namespace PlasticisingTile.Core.Models.DynamicQuery;
public class DynamicQuerySelection
{
    public DynamicQuerySelection(string selectionAttributeKey)
    {
        SelectionAttributeKey = selectionAttributeKey;
    }

    public string SelectionAttributeKey { get; set; }
    public SelectionOperationEnum SelectionOperation { get; set; }
    public object? OperationValue { get; set; }
}
