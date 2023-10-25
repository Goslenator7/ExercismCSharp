using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double successRate = 0;
        if (speed > 0 && speed < 5){ successRate = 1.0;  }
        else if (speed > 4 && speed < 9) { successRate = 0.9; }
        else if (speed == 9) { successRate = 0.8; }
        else if (speed == 10) { successRate = 0.77; }
        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double grossProduct = 221 * speed;
        double productionRate = SuccessRate(speed);
        return (double)productionRate * grossProduct;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double grossProduct = ProductionRatePerHour(speed);
        int workingProduct = (int)(grossProduct) / 60;
        return workingProduct;
    }
}