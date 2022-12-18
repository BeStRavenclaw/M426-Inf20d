using Refactoring.Animals;
using Xunit;

namespace Refactoring.Tests;

public class ZooTest
{
    [Fact]
    public void TestDogMakeNoise()
    {
        Animal dog = new Dog("Simp");
        string noise = "Simp says 'woof'";

        string actual = Zoo.MakeNoise(dog);

        Assert.Equal(noise, actual);
    }

    [Fact]
    public void TestHorseMakeNoise()
    {
        Animal horse = new Horse("Simon");
        string noise = "Simon says 'neigh'";

        string actual = Zoo.MakeNoise(horse);

        Assert.Equal(noise, actual);
    }

    [Fact]
    public void TestCowMakeNoise()
    {
        Animal cow = new Cow("Markus");
        string noise = "Markus says 'mooh'";

        string actual = Zoo.MakeNoise(cow);

        Assert.Equal(noise, actual);
    }
}