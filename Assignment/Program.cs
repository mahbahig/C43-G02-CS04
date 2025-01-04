namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The number is {number}");

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write($" {i} ");
            //}
            #endregion

            #region Q2
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The number is {number}");

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($" {number*i} ");
            //}
            #endregion

            #region Q3
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number is {number}");

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                Console.Write($" {i} ");
                }
            }
            #endregion
        }
    }
}
