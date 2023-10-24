namespace ConsoleApp1.Animals;

public class Goat : Animal
{
    public Goat(IStomach stomach, string name, float movementSpeed) : base(stomach, name, movementSpeed)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Baaa");
    }
}
