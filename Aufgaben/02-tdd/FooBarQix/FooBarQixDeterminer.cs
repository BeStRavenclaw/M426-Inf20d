namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            if (input % 3 == 0)
                return "Foo";

            if (input % 5 == 0)
                return "Bar";

            if (input % 7 == 0)
                return "Qix";

            return input.ToString();
        }
    }
}