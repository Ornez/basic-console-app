using ConsoleApp1;
using ConsoleApp1.Animals;
using ConsoleApp1.Foods;

IStomach dogStomach = new Stomach(100, 
    new FoodType[] { FoodType.Meat });
Animal dog = new Dog(dogStomach, "Klusek", 4f);

IStomach goatStomach = new Stomach(50, 
    new FoodType[] { FoodType.Plant });
Animal goat = new Goat(goatStomach, "Koza", 2f);

Food potato = new Food(FoodType.Plant, 20);
Food goatMeta = new Food(FoodType.Meat, 50);

dog.MakeSound();
goat.MakeSound();

dog.Eat(potato);
dog.Eat(goatMeta);

goat.Eat(potato);
goat.Eat(goatMeta);

Console.WriteLine("Koniec programu.");