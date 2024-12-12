class Recipes
{
    private List<string> _ingredients = new List<string>();
    private int _calories;
    private string _name;
    private string _cuisineType;
    private int _preparationTime;
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
        Console.WriteLine($"Ingredients: {_ingredients} Calories: {_calories}");

    }
}