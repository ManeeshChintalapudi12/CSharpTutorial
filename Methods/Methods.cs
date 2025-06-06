public class Methods
{
    public void Greet()
    {
        Console.WriteLine("Hello from Greet method!");
    }
    public void Welcome(string name)
    {
        Console.WriteLine($"Welcome, {name}!");
    }

    public void ShowDetails(string city = "New York")
    {
        Console.WriteLine($"City: {city}");
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    public void PrintMessage()
    {
        Console.WriteLine("No message passed.");
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }
}