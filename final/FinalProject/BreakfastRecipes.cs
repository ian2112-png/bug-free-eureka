class BreakfastRecipes: Recipes
{
    private string _breakfastFruit;
    
public BreakfastRecipes(string breakfastFruit, string name, string cuisineType, int preparationTime, List<string> ingredients, int calories) : base(name,cuisineType, preparationTime, ingredients, calories)
    {
        _breakfastFruit = breakfastFruit;
    }
public override void Display()
    {
        base.Display();
        Console.WriteLine($"Breakfast fruit: {_breakfastFruit}");
        
    }
}