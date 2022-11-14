namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class AspNetRoleClaim
{
    public long Id { get; set; }
    public string? ClaimType { get; set; }
    public string? ClaimValue { get; set; }
    public string Discriminator { get; set; } = null!;
    public long RoleId { get; set; }

    public virtual AspNetRole Role { get; set; } = null!;
}
