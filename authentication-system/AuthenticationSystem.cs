using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Authenticator(Identity admin)
{
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    private ReadOnlyDictionary<string, Identity> _developers
        = new(new Dictionary<string, Identity>
        {
            ["Bertrand"] = new() { Email = "bert@ex.ism", EyeColor = "blue" },
            ["Anders"] = new() { Email = "anders@ex.ism", EyeColor = "brown" }
        });
    
    public Identity Admin { get; } = admin;
    public IDictionary<string, Identity> GetDevelopers() => _developers;
}

public struct Identity
{
    public string Email { get; set; }
    public string EyeColor { get; set; }
}
