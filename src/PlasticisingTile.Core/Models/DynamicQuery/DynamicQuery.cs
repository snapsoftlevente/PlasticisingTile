namespace PlasticisingTile.Core.Models.DynamicQuery;
public class DynamicQuery
{
    public DynamicQuery(string tableOrViewName)
    {
        TableOrViewName = tableOrViewName;
    }

    public string TableOrViewName { get; set; }
    public IEnumerable<string> ProjectionAttributeKeys { get; set; } = new List<string>();
    public IEnumerable<DynamicQuerySelection> Selections { get; set; } = new List<DynamicQuerySelection>();
}
