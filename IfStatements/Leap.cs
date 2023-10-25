using System;

public static class Leap
{
    private static bool canDivideByFour(int year) => year % 4 == 0;
    private static bool canDivideByHundred(int year) => year % 100 == 0;
    private static bool canDivideByFourHundred(int year) => year % 400 == 0;

    public static bool IsLeapYear(int year)
    {
        if (canDivideByFour(year) && canDivideByHundred(year) && canDivideByFourHundred(year)) { return true; }
        else if (canDivideByFour(year) && canDivideByHundred(year) && !canDivideByFourHundred(year)) { return false; }
        else if ((canDivideByFour(year) && !canDivideByHundred(year))) { return true; }
        return false;
    }
}