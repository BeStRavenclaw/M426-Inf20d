namespace Refactoring.Animals;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override string GetNoise()
    {
        return Name + " says 'woof'";
    }
}