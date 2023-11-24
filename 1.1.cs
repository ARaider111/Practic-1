using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[] numbers = new int [10];
    Random rand = new Random();
    
    for (int i = 0; i < numbers.Length; i++)
    {
      numbers[i] = rand.Next(-100, 100);
    }

    int minimal = 0;
    for (int i = 1; i < numbers.Length; i++)
    {
     if(numbers[i] < numbers[minimal])
      {
        minimal = i;
      }
    }

    for (int i = 0; i < numbers.Length; i++)
    {
      Console.Write(numbers[i] + " ");
    }
    
    Console.WriteLine($" Номер минимального числа: {minimal + 1}");
  }
}