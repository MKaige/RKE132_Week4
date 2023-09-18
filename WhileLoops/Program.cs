// While-loop on tsükkel mis kestab kui mõni tingimus täitub

Random rnd = new Random();
int cpuRandom;
bool loopActive = true; //bool väärtus saab olla true või false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"Cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine()); // tuleb parssida numbriks, sest süsteem loeb automaatselt stringiks

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congrats, you won!");
        //loopActive = false; // peatab tsükli vairant 1
        break; // peatab tsükli variant 2
    }
    else
    {
        Console.WriteLine("Oops. Try again");
    }
}
Console.WriteLine("Have a nice day!");