public class Continue
{
    public void Loop()
    {
        int i = 0;
        while (i < 10)
        {
            if (i == 4)
            {
                i++;
                continue;
            }
            Console.WriteLine(i);
            i++;
        }
    }
}