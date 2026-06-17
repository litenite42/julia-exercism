public static class Darts
{
    private static double Distance(double x, double y) {
        return Math.Sqrt(x*x + y*y);
    }
    
    public static int Score(double x, double y)
    {
       int score;
        double dist = Distance(x, y);
        if (dist <= 1) score = 10;
        else if (dist <= 5) score = 5;
        else if (dist <= 10) score = 1;
        else score = 0;

        return score;
    }
}
