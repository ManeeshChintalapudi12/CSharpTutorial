public class Break
{
    public void Loop()
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
            if (i == 3)
            {
                break;
            }

        }
    }
}