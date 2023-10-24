namespace ConsoleApp1.Animals;

public class Dog : Animal
{
    public Dog(IStomach stomach, string name, float movementSpeed) 
        : base(stomach, name, movementSpeed)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }
}
