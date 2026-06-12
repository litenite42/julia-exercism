class RemoteControlCar
{
    private int metersDriven = 0;
    private int batteryPercent = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (batteryPercent == 0) {
            return "Battery empty";
        }
        
        return $"Battery at {batteryPercent}%";
    }

    public void Drive()
    {
        if (batteryPercent == 0) return;
        
        metersDriven += 20;
        batteryPercent -= 1;
    }
}
