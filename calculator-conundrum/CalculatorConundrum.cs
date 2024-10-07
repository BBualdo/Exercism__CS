using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        if (operation == "/" && operand2 == 0) return "Division by zero is not allowed.";
        return operation switch
        {
            "+" => $"{operand1} {operation} {operand2} = {SimpleOperation.Addition(operand1, operand2)}",
            "*" => $"{operand1} {operation} {operand2} = {SimpleOperation.Multiplication(operand1, operand2)}",
            "/" => $"{operand1} {operation} {operand2} = {SimpleOperation.Division(operand1, operand2)}", 
            null => throw new ArgumentNullException(),
            "" => throw new ArgumentException(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
