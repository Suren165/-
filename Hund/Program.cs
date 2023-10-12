using System;



Console.WriteLine("Välkommen till Mitt hund spel");

Hund myHund = new Hund();

Console.WriteLine("Vad vill du att din hund ska heta");
myHund.name = Console.ReadLine();

Console.WriteLine($"{myHund.name} är ett fint namn!");


while (myHund.GetAlive() == true)
{
    Console.Clear();
    myHund.PrintStats();
    Console.WriteLine("Vad vill du göra");
    Console.WriteLine($"1.Lär {myHund.name} ett nytt ord ");
    Console.WriteLine($"2.Prata med {myHund.name}");
    Console.WriteLine($"3. mata {myHund.name}");
    Console.WriteLine($"4. inget");
   
}




