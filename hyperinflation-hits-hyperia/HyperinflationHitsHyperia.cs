using System;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier) 
    {
        try
        {
            return checked(@base * multiplier).ToString();
        }
        catch (OverflowException ex)
        {
            return "*** Too Big ***";
        }   
    }

    public static string DisplayGDP(float @base, float multiplier) =>
        float.IsPositiveInfinity(@base * multiplier) ? "*** Too Big ***" : (@base * multiplier).ToString();

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            return (salaryBase * multiplier).ToString();
        }
        catch (OverflowException ex)
        {
            return "*** Much Too Big ***";
        }   
    }
}
