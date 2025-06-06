public class Inheritance
{
    public string brand = "Ford";

    public void Honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

public class Model : Inheritance
{
    public string model = "Mustang";

    public void DisplayInfo()
    {
        Console.WriteLine(brand + " " + model);
    }
}
