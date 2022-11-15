namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class AspNetRole
{
    public AspNetRole()
    {
        AspNetRoleClaims = new HashSet<AspNetRoleClaim>();
        Users = new HashSet<AspNetUser>();
    }

    public long Id { get; set; }
    public string? ConcurrencyStamp { get; set; }
    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public string? Domain { get; set; }
    public string? Name { get; set; }
    public string? NormalizedName { get; set; }
    public string? Sid { get; set; }

    public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual ICollection<AspNetUser> Users { get; set; }
}
