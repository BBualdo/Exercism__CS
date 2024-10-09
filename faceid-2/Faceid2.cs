using System;
using System.Collections.Generic;

public class FacialFeatures(string eyeColor, decimal philtrumWidth)
{
    public string EyeColor { get; } = eyeColor;
    public decimal PhiltrumWidth { get; } = philtrumWidth;

    public override bool Equals(object obj)
    {
        if (obj is null) return false;
        if (obj is FacialFeatures f) return EyeColor == f.EyeColor && PhiltrumWidth == f.PhiltrumWidth;
        return false;
    }

    public override int GetHashCode() => (EyeColor, PhiltrumWidth).GetHashCode();
}

public class Identity(string email, FacialFeatures facialFeatures)
{
    public string Email { get; } = email;
    public FacialFeatures FacialFeatures { get; } = facialFeatures;

    public override bool Equals(object obj)
    {
        if (obj is null) return false;
        if (obj is Identity i) return Email == i.Email && FacialFeatures.Equals(i.FacialFeatures);
        return false;
    }

    public override int GetHashCode() => (Email, FacialFeatures).GetHashCode();
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
