class LunchRecipes: Recipes
{
    
public LunchRecipes(string name, string cuisineType, int preparationTime, List<string> ingredients, int calories) : base(name,cuisineType, preparationTime, ingredients, calories)
    {
        
    }
public override void Display()
    {
        base.Display();
        
    }
}