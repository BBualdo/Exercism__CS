public static class Triangle
{
    public static bool IsScalene(double a, double b, double c)
    {
        if (!IsTriangle(a, b, c)) return false;
        return a != b && b != c && a != c;
    }

    public static bool IsIsosceles(double a, double b, double c)
    {
        if (!IsTriangle(a, b, c)) return false;
        return a == b || b == c || a == c;
    }

    public static bool IsEquilateral(double a, double b, double c)
    {
        if (!IsTriangle(a, b, c)) return false;
        return a == b && b == c;
    }

    private static bool IsTriangle(double a, double b, double c) => a != 0 && b != 0 && c != 0 && a + b >= c && b + c >= a && a + c >= b;
}