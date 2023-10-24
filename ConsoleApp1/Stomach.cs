using ConsoleApp1.Foods;

namespace ConsoleApp1;

public class Stomach : IStomach
{
    private int maxCalories;
    private int currentCalories;

    private FoodType[] digestible;

    public Stomach(int maxCalories, FoodType[] digestible)
    {
        this.maxCalories = maxCalories;
        currentCalories = maxCalories / 2;
        this.digestible = digestible;
    }

    public void Digest(Food food)
    {
        if (IsDigestible(food))
        {
            currentCalories += food.Calories;
            currentCalories = Math.Min(currentCalories, maxCalories);
            Console.WriteLine($"Poziom kalorii wzrósł o {food.Calories}.");
        }
        else
        {
            int minusCalories = (int)(food.Calories * 0.2f);
            currentCalories -= minusCalories;
            currentCalories = Math.Max(currentCalories, 0);
            Console.WriteLine($"To jedzenie nie było strawne, poziom kalorii spadł o {minusCalories}.");
        }
    }

    public bool IsDigestible(Food food)
    {
        return digestible.Contains(food.FoodType);
    }
}
