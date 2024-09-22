namespace ArrayList;

public class BusRoute
{
    public int Number { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }


    public BusRoute(int number, string origin, string destination)
    {
        Number = number;
        Origin = origin;
        Destination = destination;
        
    }

    public override string ToString()
    {
        return $"Number: {Number}, Origin: {Origin}, Destination: {Destination}";
    }
}