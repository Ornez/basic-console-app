namespace ConsoleApp1.Foods;

public class Food
{
    public FoodType FoodType { get; set; }
    public int Calories { get; set; }

    private int age = 5;
    private int Age 
    { 
        get 
        {
            if (age > 5)
                return age;
            return 0;
        }
        set 
        {
            age = value;
        } 
    }

    public Food(FoodType foodType, int calories)
    {
        FoodType = foodType;
        Calories = calories;
    }
}
