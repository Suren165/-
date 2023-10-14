using System;



Console.WriteLine("Välkommen till Mitt hund spel");

Hund myHund = new Hund();

Console.WriteLine("Vad vill du att din hund ska heta");
myHund.name = Console.ReadLine();

Console.WriteLine($"{myHund.name} är ett fint namn!");

Console.Clear();

while (myHund.GetAlive() == true)
{
    myHund.PrintStats();
    Console.WriteLine("Vad vill du göra");
    Console.WriteLine($"1. ge mat till {myHund.name}");
    Console.WriteLine($"2.Lär {myHund.name} ett nytt ord");
    Console.WriteLine($"3. Prata med {myHund.name}");
    Console.WriteLine($"4. Inget");

    Console.ReadLine();
    Console.Clear();

string gora = Console.ReadLine();
if (gora == "1")
{
    Console.WriteLine("vilket ord vill du lära mig");
    string word = Console.ReadLine();
    myHund.Teach(word);
}
 if(gora == "2")
{
   myHund.Hi();
}
    if (gora == "3")
    {
        myHund.feed();
    }
    else
    {
      Console.WriteLine("Gör inget  zzzzzzzz");
    }
    myHund.Tick();
}

Console.WriteLine($" {myHund.name} är död!");
Console.WriteLine("Tryck på enter för att lämna");

Console.ReadLine();






