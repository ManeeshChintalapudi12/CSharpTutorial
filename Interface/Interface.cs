interface IAnimal 
{
  void animalSound(); 
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal 
{
  public void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}