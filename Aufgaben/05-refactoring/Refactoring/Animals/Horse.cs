namespace Refactoring.Animals;

public class Horse : Animal
{
    public Horse(string name) : base(name) { }

    public override string GetNoise()
    {
        return Name + " says 'neigh'";
    }
}