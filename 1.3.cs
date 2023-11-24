using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args)
  {
    List<string> words = new List<string>();
    string word = " ";
    do
    {
         Console.Write("Введите слово (для прекращения введите пустую строку): ");
         word = Console.ReadLine();
         if (word != "")
         {
             words.Add(word);
         }
    } while (word != "");

    string shortWord = " ";
    string longWord = " ";
    int maxLenght = 0;
    int minLenght = 100000;
    foreach (string word1 in words)
    {
      int l = word1.Length;
      if (l < minLenght)
      {
        minLenght = l;
        shortWord = word1;
      }
      if (l > maxLenght)
      {
        maxLenght = l;
        longWord = word1;
      }
    }
    
    Console.WriteLine($"Самое короткое слово: {shortWord}");
    Console.WriteLine($"Самое длинное слово: {longWord}");
  }
}
