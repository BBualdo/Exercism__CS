static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance >= 5000) return 2.475f;
        if (balance >= 1000) return 1.621f;
        if (balance is >= 0 and < 1000) return 0.5f;
        return 3.213f;
    }
    public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) / 100;
    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var years = 0;
        do
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        } while (balance <= targetBalance);

        return years;
    }
}
