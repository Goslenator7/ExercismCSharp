using System;

class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    public int _distanceDriven = 0;
    public int _batteryLevel = 100;
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (_batteryLevel < _batteryDrain)
        {
            return true;
        }
        return false;
    }

    public int DistanceDriven() => _distanceDriven;

    public int DrainBattery() => _batteryLevel - _batteryDrain;


    public void Drive()
    {
        DistanceDriven();
        if (BatteryDrained() == false)
        {
            _distanceDriven += _speed;
            _batteryLevel -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);

}

class RaceTrack
{
    private int _distance;
    
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car._batteryLevel > 0)
        {
            car.Drive();
        }
    
        if (car._distanceDriven < _distance)
        {
            return false;
        }
        return true;
    }
}
