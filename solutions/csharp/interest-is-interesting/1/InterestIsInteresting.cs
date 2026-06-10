static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interestRate;

        if (balance < 0) 
            interestRate = 3.213f;
        else if (balance < 1000)
            interestRate = .5f;
        else if (balance < 5000)
            interestRate = 1.621f;
        else
            interestRate = 2.475f;

        return interestRate;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)(InterestRate(balance) / 100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal current = balance;
        int numberOfYears = 0;
        while (current < targetBalance) {
            current = current + Interest(current);
            numberOfYears++;
        }

        return numberOfYears;
    }
}
