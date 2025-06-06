public class EnumExample
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    public void Method()
    {
        Level myLevel = Level.Medium;
        Console.WriteLine(myLevel);
    }
}
