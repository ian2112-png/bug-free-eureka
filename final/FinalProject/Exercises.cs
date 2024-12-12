class Exercises
{
    List<string> _exercises;

    public Exercises()
    {
        _exercises = new List<string>();
    }
    public void AddExercise(string exercise)
    {
        _exercises.Add(exercise);
    }
    public void DeleteExercise(string exercise)
    {
        _exercises.Remove(exercise);

    }
public void DisplayExercises()
{
    foreach (var exercise in _exercises)
    {
        Console.WriteLine(exercise);
    }
}
public void RandomExercises()
{
    Random random = new Random();
    int index = random.Next(_exercises.Count);
    Console.WriteLine("Exercise for today: ");
    Console.WriteLine( _exercises[index]);
}
}