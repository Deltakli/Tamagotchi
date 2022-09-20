using System;

Console.WriteLine("Welcome to Tamagotchi!");

Tamagotchi myTama = new Tamagotchi();

Console.WriteLine("Please choose a name for your Tamagotchi!");
myTama.name = Console.ReadLine();

Console.WriteLine($"Great! {myTama.name} is a beautiful name!");

while (myTama.GetAlive() == true)
{
    Console.Clear();
    myTama.PrintStats();
    Console.WriteLine("Now what do you want to do?");
    Console.WriteLine($"1. Teach {myTama.name} a new word");
    Console.WriteLine($"2. Talk to {myTama.name}");
    Console.WriteLine($"3. Feed {myTama.name}");
    Console.WriteLine($"4. Do nothing");
    Console.WriteLine($"5. Feed {myTama.name} nitroglycerine");

    string doWhat = Console.ReadLine();
    if (doWhat == "1")
    {
        Console.WriteLine("What word?");
        string word = Console.ReadLine();
        myTama.Teach(word);
    }
    if (doWhat == "2")
    {
        myTama.Hi();
    }
    if (doWhat == "3")
    {
        myTama.Feed();
    }
    if (doWhat == "5")
    {
        myTama.nitro();
        if (myTama.GetAlive() == false)
        {
            Console.WriteLine($"OH NO! {myTama.name} EXPLODED!");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("Doing nothing...");
    }
    myTama.Tick();

}

Console.WriteLine($"OH NO! {myTama.name} is dead!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();