using System;
using System.Collections.Generic;
using System.Linq;

public abstract class SmartDevice
{
    protected bool isOn;
    protected DateTime lastOnTime;
    protected string name;

    public SmartDevice(string name)
    {
        this.name = name;
    }

    public virtual void TurnOn()
    {
        isOn = true;
        lastOnTime = DateTime.Now;
    }

    public virtual void TurnOff()
    {
        isOn = false;
    }

    public bool IsOn() => isOn;

    public TimeSpan GetOnDuration() => isOn ? DateTime.Now - lastOnTime : TimeSpan.Zero;

    public string GetName() => name;
}

public class Room
{
    private List<SmartDevice> devices = new List<SmartDevice>();

    public void AddDevice(SmartDevice device) => devices.Add(device);

    public void TurnOnAllDevices() => devices.ForEach(device => device.TurnOn());

    public void TurnOffAllDevices() => devices.ForEach(device => device.TurnOff());

    public void ReportAllItemsAndStatus() => devices.ForEach(device => Console.WriteLine($"{device.GetName()} is {(device.IsOn() ? "on" : "off")}"));

    public IEnumerable<SmartDevice> GetDevicesOn() => devices.Where(device => device.IsOn());

    public SmartDevice GetLongestRunningDevice() => devices.OrderByDescending(device => device.GetOnDuration()).FirstOrDefault();
}

public class House
{
    private List<Room> rooms = new List<Room>();

    public void AddRoom(Room room) => rooms.Add(room);

    public void TurnOnAllLights() => rooms.ForEach(room => room.TurnOnAllDevices());

    public void TurnOffAllLights() => rooms.ForEach(room => room.TurnOffAllDevices());

    public void ReportAllItemsInRoomsAndStatus() => rooms.ForEach(room => { Console.WriteLine($"Items in Room:"); room.ReportAllItemsAndStatus(); Console.WriteLine(); });

    public IEnumerable<SmartDevice> GetDevicesOn() => rooms.SelectMany(room => room.GetDevicesOn());

    public SmartDevice GetLongestRunningDevice() => rooms.SelectMany(room => room.GetDevices()).OrderByDescending(device => device.GetOnDuration()).FirstOrDefault();
}

class Program
{
    static void Main(string[] args)
    {
        House house = new House();

        Room livingRoom = new Room();
        livingRoom.AddDevice(new SmartDevice("Living Room Light"));
        livingRoom.AddDevice(new SmartDevice("Living Room TV"));

        Room bedroom = new Room();
        bedroom.AddDevice(new SmartDevice("Bedroom Light"));
        bedroom.AddDevice(new SmartDevice("Bedroom Heater"));

        house.AddRoom(livingRoom);
        house.AddRoom(bedroom);

        livingRoom.TurnOnAllDevices();
        bedroom.AddDevice(new SmartDevice("Another Bedroom Heater"));

        house.ReportAllItemsInRoomsAndStatus();

        Console.WriteLine("Devices currently on:");
        house.GetDevicesOn().ToList().ForEach(device => Console.WriteLine(device.GetName()));

        SmartDevice longestRunningDevice = house.GetLongestRunningDevice();
        Console.WriteLine($"Longest running device: {(longestRunningDevice != null ? longestRunningDevice.GetName() : "None")}");
    }
}
