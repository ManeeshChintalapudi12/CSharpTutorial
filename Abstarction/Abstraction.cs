abstract class Animal
{
  public abstract void animalSound();
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

class Pigs : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The pig says: wee wee");
  }
}
