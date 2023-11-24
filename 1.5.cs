using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.Write("Введите строку: ");
    string input = Console.ReadLine();
    string[] inputString = input.Split();
    string modifString = $"start {input} end";

    Console.WriteLine($"Количество слов в строке: {inputString.Length}");
    Console.WriteLine($"Измененная строка: {modifString}");
  }
}
