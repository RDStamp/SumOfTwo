namespace SumOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var response = Exercise.SumOfTwo([1, 1, 1, 2, 3, 4, 5, 2], 2);
            Console.WriteLine(response);

            response = Exercise.SumOfTwo([2, 3, 2, 3, 2, 3, 2, 3, 2, 3, 1, 4, 1, 4, 5, 0, 5, 0], 5);
            Console.WriteLine(response);
        }
    }
}
