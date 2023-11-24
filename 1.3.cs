using System;
using System.Collections.Generic;

class Program 
{
  public static void Main (string[] args) 
  {
    List<string> elements = new List<string>();
    string input;
    
    do
    {
      Console.Write("Введите слова (пустая строка для завершения): ");
      input = Console.ReadLine();

      if (input!="")
      {
        elements.Add(input);
      }
    }while (input!="");

    string shortest = elements[0];
    string longest = elements[0];

    foreach (string element in elements)
    {
      if (element.Length < longest.Length)
      {
        shortest = element;
      }
      if (element.Length > shortest.Length)
      {
        longest = element;
      }
    }
    Console.WriteLine($"Самый короткий элемент: {shortest}");
    Console.WriteLine($"Самый длинный элемент: {longest}");
  }
}