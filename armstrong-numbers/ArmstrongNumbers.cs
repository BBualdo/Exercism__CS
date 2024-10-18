using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var numbersStr = number.ToString();
        char[] nums = numbersStr.ToCharArray();

        var sum = 0;
        foreach (var num in nums)
        {
            sum += (int)Math.Pow(int.Parse(num.ToString()), nums.Length);
        }

        return sum == number;
    }
}