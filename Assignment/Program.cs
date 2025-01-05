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
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The number is {number}");

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //    Console.Write($" {i} ");
            //    }
            //}
            #endregion

            #region Q4
            //Console.Write("Enter the base number: ");
            //int baseNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter the power number: ");
            //int powerNumber = int.Parse(Console.ReadLine());

            //int total = 1;

            //for (int i = 0; i < powerNumber; i++)
            //{
            //    total *= baseNumber;
            //}

            //Console.WriteLine($"The answer is {total}");
            #endregion

            #region Q5
            //Console.Write("Enter a word: ");
            //string word = Console.ReadLine();

            //string reverseWord = "";

            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    reverseWord += word[i];
            //}

            //Console.WriteLine($"The reverse word is {reverseWord}");
            #endregion

            #region Q6
            //Console.Write("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine($"The prime number between {start} and {end} are :");

            //bool isPrime;

            //for (int i = start; i < end; i++)
            //{
            //    isPrime = true;
            //    for (int j = 2; j < 9; j++)
            //    {
            //        if (i % j == 0 && i != j) {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (i == 1)
            //    {
            //        isPrime = false;
            //    }
            //    if (isPrime)
            //    {
            //        Console.Write($" {i} ");
            //    }
            //}
            #endregion

            #region Q7
            Console.Write("Enter a number to convert : ");
            int number = int.Parse(Console.ReadLine());

            string binary = "";
            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary;
                number /= 2;
                Console.WriteLine(number);
            }

            Console.WriteLine($"The binary representation is {binary}");
            #endregion
        }
    }
}
