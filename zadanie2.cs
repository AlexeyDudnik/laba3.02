using System;
public class Vehicle
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Price { get; set; }
    public double Speed { get; set; }
    public int Year { get; set; }
    public Vehicle(double x, double y, double price, double speed, int year)
    {
        X = x;
        Y = y;
        Price = price;
        Speed = speed;
        Year = year;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"{X}, {Y}");
        Console.WriteLine(Price);
        Console.WriteLine(Speed);
        Console.WriteLine(Year);
    }
}
public class Plane : Vehicle
{
    public double Height { get; set; }
    public int Passengers { get; set; }
    public Plane(double x, double y, double price, double speed, int year, double height, int passengers) : base(x, y, price, speed, year)
    {
        Height = height;
        Passengers = passengers;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine(Height);
        Console.WriteLine(Passengers);
    }
}
public class Car : Vehicle
{
    public Car(double x, double y, double price, double speed, int year) : base(x, y, price, speed, year){}
    public override void ShowInfo()
    {
        base.ShowInfo();
    }
}
public class Ship : Vehicle
{
    public int Passengers { get; set; }
    public string HomePort { get; set; }
    public Ship(double x, double y, double price, double speed, int year, int passengers, string homePort) : base(x, y, price, speed, year)
    {
        Passengers = passengers;
        HomePort = homePort;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine(Passengers);
        Console.WriteLine(HomePort);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vehicle plane = new Plane(100, 200, 1000000, 900, 2020, 10000, 200);
        Vehicle car = new Car(50, 50, 30000, 200, 2019);
        Vehicle ship = new Ship(0, 0, 5000000, 50, 2018, 500, "New York");
        Console.WriteLine("--- Plane Info ---");
        plane.ShowInfo();
        Console.WriteLine();
        Console.WriteLine("--- Car Info ---");
        car.ShowInfo();
        Console.WriteLine();
        Console.WriteLine("--- Ship Info ---");
        ship.ShowInfo();
    }
}
