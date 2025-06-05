using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        // //     // (Variables)
        //     Console.WriteLine("Hello, World!");

        //     Variables variables = new Variables();
        //     variables.Integer();

        //     variables.Double();

        //     variables.Char();

        //     variables.String();

        //     variables.Boolean();

        // }

        // //DataTypes
        // {
        //     DataTypes data = new DataTypes();
        //     data.Integer();

        //     data.Long();

        //     data.Float();

        //     data.Double();

        //     data.Char();

        //     data.String();

        //     data.Boolean();
        // }

        //     // //TypeCasting
        //     {
        //         TypeCasting data = new TypeCasting();
        //         data.Implict();

        //         data.Explict();
        //     }

        //     // Operators

        //     Operators data = new Operators();
        //     data.Add();

        //     data.Sub();

        //     data.Div();

        //     data.Multi();

        // }    

        // //MathOperations
        // MathOperation data = new MathOperation();
        // data.Maximum();

        // data.Minimum();

        // data.SquareRoot();

        // data.Figure();

        // //Strings
        // Strings data = new Strings();
        // data.Concatination();

        // data.Interpolation();

        //     //Conditional Statments
        //     Conditional data = new Conditional();
        //     data.Statments();

        //     // Switch
        //     Switch data = new Switch();
        //     data.Statments();

        // //While Loop
        // While data = new While();
        // data.Condition();

        // data.State();

        // //For Loop
        // For data = new For();
        // data.Loop();

        // //Break
        // Break data = new Break();
        // data.Loop();

        // // Continue
        // Continue data = new Continue();
        // data.Loop();

        // Arrays
        //     Arrays data = new Arrays();
        //     data.Method();

        //     data.Extract();

        //Methods
        Methods data = new Methods();
        data.Greet();

        data.Welcome("King");

        data.ShowDetails("Chicago");

        int sum = data.Add(10, 20);
        Console.WriteLine("Sum: " + sum);

        data.DisplayInfo(age: 25, name: "Aparna");

        data.PrintMessage();
        data.PrintMessage("Hello");
    }

}