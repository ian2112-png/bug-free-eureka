class DinnerRecipes: Recipes
{
    private string _dinnerVegetable;
    
public DinnerRecipes(string dinnerVegetable, string name, string cuisineType, int preparationTime, List<string> ingredients, int calories) : base(name,cuisineType, preparationTime, ingredients, calories)
    {
        _dinnerVegetable = dinnerVegetable;
    }
public override void Display()
    {
        base.Display();
        Console.WriteLine($"Dinner vegetable: {_dinnerVegetable}");
        
    }
}