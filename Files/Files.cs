public class Files
{
    public void Data()
    {
      string writeText = "Hello World!";  
      File.WriteAllText("filename.txt", writeText); 

      string readText = File.ReadAllText("filename.txt");
      Console.WriteLine(readText);
    }
}