using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public override bool Equals(object obj)
    {
        if (obj is null) return false;
        var other = (FacialFeatures)obj;
        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 31 + EyeColor.GetHashCode();
        hash = hash * 31 + PhiltrumWidth.GetHashCode();
        return hash;
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(object obj)
    {
        if (obj is null) return false;
        var other = (Identity)obj;
        return Email == other.Email && FacialFeatures.Equals(other.FacialFeatures);
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 31 + Email.GetHashCode();
        hash = hash * 31 + FacialFeatures.GetHashCode();
        return hash;
    }
}

public class Authenticator
{
    private HashSet<Identity> Identities { get; set; } = [];
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity) => identity.Equals(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m)));

    public bool Register(Identity identity) => Identities.Add(identity);
    
    public bool IsRegistered(Identity identity) => Identities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}
