namespace PlasticisingTile.API.Configuration;

public class CorsOptions
{
    public const string Cors = "Cors";
    public const string CorsPolicyName = "WebAppCorsPolicy";

    public string Origin { get; set; } = string.Empty;
}
