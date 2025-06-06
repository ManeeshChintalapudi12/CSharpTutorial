public class Polymorphism
{
    public string brand = "BMW";
}

public class Vehicle : Polymorphism
{
    public string model = "ESport";

    public void Method()
    {
        Console.WriteLine(brand + " " + model);
    }
}

public class Inher : Vehicle
{
    public string year = "2020";

    public void Company()
    {
        Console.WriteLine(brand + " " + year);
    }
}
