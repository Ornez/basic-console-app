using ConsoleApp1.Foods;

namespace ConsoleApp1.Animals;

public abstract class Animal
{
    private IStomach stomach;

    protected string name = "Unidentified animal";
    protected float movementSpeed;

    public Animal(IStomach stomach, string name, float movementSpeed)
    {
        this.stomach = stomach;
        this.name = name;
        this.movementSpeed = movementSpeed;
    }

    public void Eat(Food food)
    {
        stomach.Digest(food);
    }

    public abstract void MakeSound();
}
