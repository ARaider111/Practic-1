  using System;
  using System.Collections.Generic;
  class Program
  {
      static void Main()
      {
          List<int> numbers = new List<int>();
          int num = 0;
          do
          {
               Console.Write("Введите число (для прекращения введите '0'): ");
               num = Convert.ToInt32(Console.ReadLine());
               if (num != 0)
               {
                   numbers.Add(num);
               }
          } while (num != 0);

          int sumNumbers = 0;
          int productNumbers = 1;

          foreach (int number in numbers)
          {
              sumNumbers += number;
              productNumbers *= number;
          }
          float average = 0;
          average = (float) sumNumbers / (float) numbers.Count;

          Console.WriteLine($"Сумма всех чисел: {sumNumbers}");
          Console.WriteLine($"Произведение всех чисел: {productNumbers}");
          Console.WriteLine($"Среднее арифметическое чисел: {average}");
      }
  }