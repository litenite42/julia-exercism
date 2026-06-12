class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int metersDriven = 0;
    private int batteryPercent = 100;
    private int batteryDrainPerMove;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        batteryDrainPerMove = batteryDrain;
    }
    
    public bool BatteryDrained()
    {
        return batteryPercent < batteryDrainPerMove;
    }

    public int DistanceDriven()
    {
        return metersDriven;
    }

    public void Drive()
    {
        if (BatteryDrained()) return;
        
        metersDriven += speed;
        batteryPercent -= batteryDrainPerMove;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int length;

    public RaceTrack(int distance) {
        length = distance;
    }    

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained()) {
            car.Drive();
        }

        return car.DistanceDriven() >= length;
    }
}
