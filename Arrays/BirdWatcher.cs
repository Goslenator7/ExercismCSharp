using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] countLastWeek = {0, 2, 5, 3, 7, 8, 4};
        return countLastWeek;
    }

    public int Today() => birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
          if (birdsPerDay[i] == 0)
          {
              return true;
          }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i <= numberOfDays - 1; i++)
        {
            total += birdsPerDay[i];
        }
    return total;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
          if (birdsPerDay[i] > 4)
          {
              busyDays++;
          }
        }
    return busyDays;
    }
}
