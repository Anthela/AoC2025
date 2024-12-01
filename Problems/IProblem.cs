namespace Advent_of_Code_24.Problems
{
    public interface IProblem<T, U>
    {
        public T DoPartA();

        public U DoPartB();
    }
}
