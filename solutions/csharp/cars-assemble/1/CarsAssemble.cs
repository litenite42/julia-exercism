static class AssemblyLine
{
    public static int CarsPerHour = 221;
    public static double SuccessRate(int speed)
    {
        double successRate;

        if (speed == 0) {
            successRate = 0;
        } else if (speed > 0 && speed < 5) {
            successRate = 1.0;
        } else if (speed > 4 && speed < 9) {
            successRate = .9;
        } else if (speed == 9) {
            successRate = .8;
        } else {
            successRate = .77;
        }

        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * CarsPerHour * speed;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int) (ProductionRatePerHour(speed) / 60);
    }
}
