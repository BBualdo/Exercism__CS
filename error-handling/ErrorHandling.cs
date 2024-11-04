using System;
using System.Globalization;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException() => throw new Exception();
    public static int? HandleErrorByReturningNullableType(string input) => int.TryParse(input, new CultureInfo("en-US"), out int result) ? result : null;
    public static bool HandleErrorWithOutParam(string input, out int result) => int.TryParse(input, new CultureInfo("en-US"), out result);
    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        using (disposableObject)
            throw new Exception();
    }
}
