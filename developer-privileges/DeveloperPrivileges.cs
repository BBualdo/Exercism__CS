using System.Collections.Generic;

public class Authenticator
{
    public Identity Admin { get; } = new()
    {
        FacialFeatures = new FacialFeatures { EyeColor = "green", PhiltrumWidth = 0.9m },
        Email = "admin@ex.ism",
        NameAndAddress = new List<string> { "Chanakya", "Mumbai", "India" }
    };

    public IDictionary<string, Identity> Developers { get; } = new Dictionary<string, Identity>
    {
        {
            "Bertrand", new Identity
            {
                FacialFeatures = new FacialFeatures { EyeColor = "blue", PhiltrumWidth = 0.8m },
                Email = "bert@ex.ism",
                NameAndAddress = new List<string> { "Bertrand", "Paris", "France" }
            }
        },
        {
            "Anders", new Identity
            {
                FacialFeatures = new FacialFeatures { EyeColor = "brown", PhiltrumWidth = 0.85m },
                Email = "anders@ex.ism",
                NameAndAddress = new List<string> { "Anders", "Redmond", "USA" }
            }
        }
    };
}

//**** please do not modify the FacialFeatures class ****
public class FacialFeatures
{
    public string EyeColor { get; set; }
    public decimal PhiltrumWidth { get; set; }
}

//**** please do not modify the Identity class ****
public class Identity
{
    public string Email { get; set; }
    public FacialFeatures FacialFeatures { get; set; }
    public IList<string> NameAndAddress { get; set; }
}