public class Properties
{
    private string name ="Mani";

    public string Name
    {
        get { return name; }
        set { name ="Mani"; }
    }
    public void Method()
    {
        Console.WriteLine(Name);
    }
}