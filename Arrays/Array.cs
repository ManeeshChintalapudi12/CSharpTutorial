public class Arrays
{
    public void Method()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }

    public void Extract()
    {
        int[] myNumbers = { 5, 1, 8, 9 };
        Array.Sort(myNumbers);
        foreach (int i in myNumbers)
        {
            Console.WriteLine(i);
        }
    }
}