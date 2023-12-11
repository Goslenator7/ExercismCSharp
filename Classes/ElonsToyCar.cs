using System;

class RemoteControlCar
{
    private int _batteryLevel = 100;
    private int _distanceDriven = 0;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (_batteryLevel > 0)
        {
            return $"Battery at {_batteryLevel}%";
        }
        return $"Battery empty";
    }

    public void Drive()
    {
        if (_batteryLevel > 0)
        {
        _distanceDriven += 20;
        _batteryLevel -= 1;
        }
    BatteryDisplay();
    }
}
