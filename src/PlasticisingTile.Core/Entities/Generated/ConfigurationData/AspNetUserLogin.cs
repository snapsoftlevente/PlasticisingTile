﻿namespace PlasticisingTile.Core.Entities.ConfigurationData;

public partial class AspNetUserLogin
{
    public string LoginProvider { get; set; } = null!;
    public string ProviderKey { get; set; } = null!;
    public string? ProviderDisplayName { get; set; }
    public long UserId { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
