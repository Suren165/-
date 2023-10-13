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

    Console.ReadLine();
    Console.Clear();
}
string gora = Console.ReadLine();

Console.ReadLine();






