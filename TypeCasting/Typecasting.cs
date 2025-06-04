public class TypeCasting
{
    public void Implict()
    {
        int myInt = 9;
        double myDouble = myInt;

        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);
    }

    public void Explict()
    {
        double myDouble = 9.78;
        int myInt = (int) myDouble;    

        Console.WriteLine(myDouble);   
        Console.WriteLine(myInt); 
    }
}