using System;
static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) { return 3.213F; }
        else if (balance >= 0 && balance < 1000) { return 0.5F; }
        else if (balance >= 1000 && balance < 5000) { return 1.621F; }
        else { return 2.475F; }
    }
    public static decimal Interest(decimal balance)
    {
        decimal interestRate = (decimal)InterestRate(balance);
        return interestRate * balance / 100;
    }
    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal addedInterest = Interest(balance);
        return balance + addedInterest;
    }
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance <= targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}