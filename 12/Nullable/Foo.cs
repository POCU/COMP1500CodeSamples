namespace Nullable
{
    public class Foo
    {
        public Foo(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }

        public void Increment()
        {
            Number++;
        }

        public void Increment(int increment)
        {
            Number += increment;
        }
    }
}
