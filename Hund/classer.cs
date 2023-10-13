
using System;
using System.Collections.Generic;



public class Hund
{
  private int hunger;
  private int boredom;

  private List<string> words = new List<string>() { "voff" };
  private bool isAlive;
  private Random generator;

  public string name;


  public Hund()
  {
    generator = new Random();
    isAlive = true;
  }

  public void feed()
  {
    Console.WriteLine($"[{name}] Jag är full nu tack ");

    hunger -= 2;
    if (hunger < 0)
    {
      hunger = 0;
      Console.WriteLine($"{name} är redan mätt!");
    }
  }


  public bool GetAlive()
  {
    if (isAlive)
    {
      return true;
    }
    return false;
  }

  public void Hi()
  {
    int wordNum = generator.Next(words.Count);
    Console.WriteLine($" [{name}] säger: {words[wordNum]}");
    ReduceBoredom();
  }

  public void Teach(string word)
  {
    Console.WriteLine($" [{name}] lär: {word}");
    words.Add(word);
    ReduceBoredom();
  }
public void Tick()
{
  hunger++;
  boredom++;
  if (hunger > 10 || boredom > 10)
  {
    isAlive = false;
  }
}


  public void PrintStats()
  {
    Console.WriteLine($"Hunger: {hunger}");
    Console.WriteLine($"Uttråkad:{boredom}");
  }

  public void ReduceBoredom()
  {
    Console.WriteLine($"Nu är glad [{name}] ");
    boredom -= 2;
    if (boredom < 0)
    {
      boredom = 0;
    }
  }


}















