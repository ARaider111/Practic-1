using System;

class Program {
  public static void Main (string[] args)
  {
    string stringWords = "";
    Console.WriteLine ("Введите строку слов(Через запятую): ");
    stringWords = Console.ReadLine();
    stringWords = "start, " + stringWords + ", end";
    string[] words = stringWords.Split();
    for(int i = 0; i < words.Length; ++i)
    {
      Console.Write(words[i] + " ");
    }
    
    Console.WriteLine(" ");
    Console.WriteLine($"Количество слов в строке: {(words.Length) - 2}");
  }
}