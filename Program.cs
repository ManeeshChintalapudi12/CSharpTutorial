internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Variables variables = new Variables();
        variables.Integer();

        Variables obj = new Variables();
        obj.Double();

        Variables name = new Variables();
        name.Char();

        Variables myName = new Variables();
        myName.String();

        Variables mybool = new Variables();
        mybool.Boolean();
    }
}