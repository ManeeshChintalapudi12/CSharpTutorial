public class While
{
    public void Condition()
    {
        int x = 0;
        while (x < 5)
        {
            Console.WriteLine(x);
            x++;
        }
    }

    public void State()
    {
        int x = 0;
        do
        {
            Console.WriteLine(x);
            x++;
        }
        while (x < 5);
        
    }
}