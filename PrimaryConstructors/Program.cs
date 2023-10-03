var distanceOld = new DistanceOld(1, 2);
var distanceNew = new DistanceNew(1, 2);
var closerDistance = new CloserDistance(1, 2);


Console.WriteLine($"OldWay: {distanceOld.Direction}");
Console.WriteLine($"\nNewWay: {distanceNew.Direction}");
Console.WriteLine($"\nCloserDistance: {closerDistance.Direction}");

Console.ReadLine();

public readonly struct DistanceOld
{
    public readonly double Magnitude { get; }

    public readonly double Direction { get; }

    public DistanceOld(double dx, double dy)
    {
        Magnitude = Math.Sqrt(dx * dx + dy * dy);
        Direction = Math.Atan2(dy, dx);
    }
}


public readonly struct DistanceNew(double dx, double dy)
{
    public readonly double Magnitude { get; } = Math.Sqrt(dx * dx + dy * dy);
    public readonly double Direction { get; } = Math.Atan2(dy, dx);
}

public class CloserDistance(double dx, double dy)
{
    public double Magnitude { get; } = dx * dy;
    public double Direction { get; } = dx;

    //when we create another constructor, we have to initialize it with this and arguments from primary constructor
    public CloserDistance() : this(0, 0) { }
}