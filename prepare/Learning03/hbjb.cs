using System;

public class Car
{
    private string color;
    private int speed;

    public Car(string carColor)
    {
        color = carColor;
        speed = 0;
    }

    public void StartEngine()
    {
        Console.WriteLine("Engine started");
    }

    public void Accelerate(int increment)
    {
        speed += increment;
        Console.WriteLine("Accelerating by " + increment + " mph");
    }

    public string GetColor()
    {
        return color;
    }

    public int GetSpeed()
    {
        return speed;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("blue");

        Console.WriteLine("Car color: " + myCar.GetColor());
        myCar.StartEngine();
        myCar.Accelerate(20);
    }
}
