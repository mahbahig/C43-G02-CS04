namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number is {number}");

            for (int i = 1; i <= number; i++)
            {
                Console.Write($" {i} ");
            }
            #endregion
        }
    }
}
