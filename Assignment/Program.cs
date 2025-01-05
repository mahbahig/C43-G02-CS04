﻿namespace Assignment
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
            //Console.Write("Enter a number to convert : ");
            //int number = int.Parse(Console.ReadLine());

            //string binary = "";
            //while (number > 0)
            //{
            //    int remainder = number % 2;
            //    binary = remainder + binary;
            //    number /= 2;
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine($"The binary representation is {binary}");
            #endregion

            #region Q8
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j < number; j++)
            //    {
            //        if (j == i)
            //        {
            //            Console.Write($" {1} ");
            //        }
            //        else
            //        {
            //            Console.Write($" {0} ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q9
            //Console.Write("Enter a word: ");
            //string word = Console.ReadLine();

            //Console.Write("Enter the start of the substring: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Enter the end of the substring: ");
            //int end = int.Parse(Console.ReadLine());

            //string subString = "";

            //for (int i = start; i < end; i++)
            //{
            //    subString += word[i];
            //}
            //Console.WriteLine($"The substring is: {subString}");

            #endregion

            #region Q10
            //Console.Write("Enter a word: ");
            //string word = Console.ReadLine();
            //Console.Write("Enter another word: ");
            //string word2 = Console.ReadLine();

            //string combinedWord = word + word2;
            //Console.Write(combinedWord);
            #endregion

            #region Q11
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j < number; j++)
            //    {
            //        if (j == i)
            //        {
            //            Console.Write($" {1} ");
            //        }
            //        else
            //        {
            //            Console.Write($" {0} ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q12
            //int[] numbers = { 1, 2, 3 };
            //int sum = 0;
            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Q13
            //int[] first = { 1, 3, 5 };
            //int[] second = { 2, 4, 6 };

            //int[] combined = new int[first.Length + second.Length];

            //int firstIndex = 0, secondIndex = 0, combinedIndex = 0;
            //while (firstIndex < first.Length && secondIndex < second.Length)
            //{
            //    if (first[firstIndex] < second[secondIndex])
            //    {
            //        combined[combinedIndex++] = first[firstIndex++];
            //    }
            //    else
            //    {
            //        combined[combinedIndex++] = second[secondIndex++];
            //    }
            //}
            //while (firstIndex < first.Length)
            //{
            //    combined[combinedIndex++] = first[firstIndex++];
            //}
            //while (secondIndex < second.Length)
            //{
            //    combined[combinedIndex++] = second[secondIndex++];
            //}
            //foreach (var item in combined)
            //{
            //    Console.Write($" {item} ");
            //}
            #endregion

            #region Q14
            int[] array = { 5, 3, 5, 1, 3, 5 };

            Console.WriteLine("Frequency of each element:");
            for (int i = 0; i < array.Length; i++)
            {
                bool alreadyCounted = false;
                for (int k = 0; k < i; k++)
                {
                    if (array[i] == array[k])
                    {
                        alreadyCounted = true;
                        break;
                    }
                }
                if (alreadyCounted) continue;
                int count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Element {array[i]} occurs {count} times.");
            }
            #endregion
        }
    }
}
