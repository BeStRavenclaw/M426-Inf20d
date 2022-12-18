namespace Refactoring.Animals;

public class Zoo
{
    public static string MakeNoise(Animal animal)
    {
        return animal.GetNoise();
        throw new ArgumentException("unknown animal, unknown sound");
    }
}