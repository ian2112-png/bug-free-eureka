class Recipes
{
    private List<string> _ingredients = new List<string>();
    private int _calories;
    private string _name;
    private string _cuisineType;
    private int _preparationTime;

    public Recipes()
    {
        
    }
    public Recipes(string name, string cuisineType, int preparationTime, List<string> ingredients, int calories)
    {
        _ingredients = ingredients;
        _calories = calories;
        _name = name;
        _cuisineType = cuisineType;
        _preparationTime = preparationTime;
    }
    public void AddIngredient(string ingredient)
    {
        _ingredients.Add(ingredient);
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string value)
    {
        _name = value;
    }
    public string GetCuisineType()
    {
        return _cuisineType;
    }
    public void SetCuisineType(string type)
    {
        _cuisineType = type;
    }
    public int GetPreparationTime()
    {
        return _preparationTime;
    }
     public void SetPreparationTime(int value)
    {
        _preparationTime = value;
    }
    public virtual void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Cuisine Type: {_cuisineType}");
        Console.WriteLine("Ingredients:");
        foreach(var ingredient in _ingredients)
        {
            Console.Write(ingredient);
        }
        Console.WriteLine("");
        Console.WriteLine($"Calories: {_calories}");

    }
    public void Create()
    {
         Console.WriteLine("You will create your own recipes and be prompted to enter information.");
        List<Recipes> recipeList = new List<Recipes>();
        Console.WriteLine("Enter recipe name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter cuisine type:");
        string type = Console.ReadLine();

        Console.WriteLine("Enter preparation time in minutes: ");
        int time = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the ingredients (separated by commas):");
        List<string> ingredients = Console.ReadLine().Split(',').ToList();

        Console.WriteLine("Enter number of calories:");
        int calories = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter breakfast fruit. Press enter if none: ");
        string breakfastFruit = Console.ReadLine();

        Console.WriteLine("Enter dinner vegetable. Press enter if none: ");
        string dinnerVegetable = Console.ReadLine();
    

    if (!string.IsNullOrEmpty(breakfastFruit))
    {
        recipeList.Add(new BreakfastRecipes(breakfastFruit, name, type, time,ingredients, calories));
    }
    else if (!string.IsNullOrEmpty(dinnerVegetable))
    {
        recipeList.Add(new DinnerRecipes(dinnerVegetable, name, type, time, ingredients, calories));
    }
    else
    {
        recipeList.Add(new LunchRecipes(name, type, time, ingredients, calories));
        
    }
    foreach(var recipe in recipeList)
    {
        recipe.Display();
    }
    }
}