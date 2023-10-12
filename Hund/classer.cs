
using System;
using System.Collections.Generic;



public class hund
{
private int hunger;
private int boredom;

private List <string> words = new List <string>() {"voff"};
private bool isAlive;
private Random generator;

public string name;


public hund()
  {
    generator = new Random();
    isAlive = true;
  }

  public void feed()
  {
Console.WriteLine($"[{name}] Jag är full nu tack ");  

hunger -=3;
if (hunger > 0);
{
  hunger = 0;
}


  }

}
  




 

