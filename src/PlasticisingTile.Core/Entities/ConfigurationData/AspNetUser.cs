namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class AspNetUser
{
    public AspNetUser()
    {
        AspNetUserClaims = new HashSet<AspNetUserClaim>();
        AspNetUserLogins = new HashSet<AspNetUserLogin>();
        AspNetUserTokens = new HashSet<AspNetUserToken>();
        Roles = new HashSet<AspNetRole>();
    }

    public long Id { get; set; }
    public long AccessFailedCount { get; set; }
    public string? ConcurrencyStamp { get; set; }
    public string? DisplayName { get; set; }
    public string? Domain { get; set; }
    public string? Email { get; set; }
    public long EmailConfirmed { get; set; }
    public long LockoutEnabled { get; set; }
    public string? LockoutEnd { get; set; }
    public string? NormalizedEmail { get; set; }
    public string? NormalizedUserName { get; set; }
    public string? PasswordHash { get; set; }
    public string? PhoneNumber { get; set; }
    public long PhoneNumberConfirmed { get; set; }
    public string? SecurityStamp { get; set; }
    public string? Sid { get; set; }
    public long TwoFactorEnabled { get; set; }
    public string? UserName { get; set; }
    public string Language { get; set; } = null!;
    public string UnitSystem { get; set; } = null!;
    public string? DataEncoderOptions { get; set; }
    public string? Timezone { get; set; }

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual ICollection<AspNetRole> Roles { get; set; }
}
