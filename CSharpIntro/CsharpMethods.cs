// //Methods // 

class CsharpMethods
{
    public static void MyMethod()
    {
        PrintPerson("Liam", 5);
        PrintPerson("Jenny", 8);
        PrintPerson("Anja", 31);
    }

    private static void PrintPerson(string fname, int age)
    {
        Console.WriteLine(fname + " is " + age);
    }
}