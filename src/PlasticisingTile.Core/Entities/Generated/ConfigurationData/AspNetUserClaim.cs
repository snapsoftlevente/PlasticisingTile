namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class AspNetUserClaim
{
    public long Id { get; set; }
    public string? ClaimType { get; set; }
    public string? ClaimValue { get; set; }
    public string Discriminator { get; set; } = null!;
    public long UserId { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
