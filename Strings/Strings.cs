public class Strings
{
    public void Concatination()
    {
        string myName = "Mohan";
        string myName1 = "Chintalapudi";
        Console.WriteLine(myName + myName1);
    }

    public void Interpolation()
    {
        string firstName = "John";
        string lastName = "Doe";
        string name = $"My full name is: {firstName} {lastName}";
        Console.WriteLine(name);
    }
}