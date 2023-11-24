
using System;

class Program
{
  static int[] GenerateRandomNumbers(int start, int end, int length)
  {
    Random random = new Random();
    int[] randomNumbers = new int[length];

    for (int i = 0; i < length; i++)
    {
      randomNumbers[i] = random.Next(start, end + 1);
    }
    return randomNumbers;
  }
  
  static void Main()
  {
    Console.Write("Введите начало диапазона: ");
    int startRange = int.Parse(Console.ReadLine());

    Console.Write("Введите конец диапазона: ");
    int endRange = int.Parse(Console.ReadLine());

    Console.Write("Введите длину массива: ");
    int arrayLength = int.Parse(Console.ReadLine());

    int[] randomNumbers = GenerateRandomNumbers(startRange, endRange, arrayLength);

    Console.WriteLine("\nСгенерированные случайные числа:");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
      Console.Write($"{randomNumbers[i]} ");
    }
    Console.WriteLine();
  }
}