using System.Data;
using System.Text.RegularExpressions;

List<string> first = new List<string>   { "D", "L", "V", "T", "M", "H", "F" };
List<string> second = new List<string>  { "H", "Q", "G", "J", "C", "T", "N", "P" };
List<string> third = new List<string>   { "R", "S", "D", "M", "P", "H" };
List<string> fourth = new List<string>  { "L", "B", "V", "F" };
List<string> fifth = new List<string>   { "N", "H", "G", "L", "Q" };
List<string> sixth = new List<string>   { "W", "B", "D", "G", "R", "M", "P" };
List<string> seventh = new List<string> { "G", "M", "N", "R", "C", "H", "L", "Q" };
List<string> eighth = new List<string>  { "C", "L", "W" };
List<string> ninth = new List<string>   { "R", "D", "L", "Q", "J", "Z", "M", "T" };


List<List<string>> crateStacks = new List<List<string>>
{
    first,
    second,
    third,
    fourth,
    fifth,
    sixth,
    seventh,
    eighth,
    ninth,

};

string[] input = System.IO.File.ReadAllLines(@"C:\Users\christian.schulze\source\repos\AdventofCode\Day5\ConsoleApp1\ConsoleApp1\Input.txt");

foreach(string command in input)
{
    int i = 0;
    int numCrates = Int32.Parse(Regex.Match(command, @"\d+").Value);
    int origin = command[command.Length - 6] - '1';
    int destination = command[command.Length - 1] - '1';

    while(i < numCrates)
    {
        Console.WriteLine(command);
        Console.WriteLine($"Stack origin {origin} before: ");

        foreach(string crate in crateStacks[origin])
        {
            Console.WriteLine(crate);
        }

        Console.WriteLine($"Stack destination {destination} before: ");

        foreach (string crate in crateStacks[destination])
        {
            Console.WriteLine(crate);
        }
        string lastItem = crateStacks[origin].LastOrDefault();

        crateStacks[destination].Add(lastItem);

        int toRemove = crateStacks[origin].Count - 1;

        crateStacks[origin].RemoveAt(toRemove);

        Console.WriteLine($"Stack origin {origin} after: ");

        foreach (string crate in crateStacks[origin])
        {
            Console.WriteLine(crate);
        }

        Console.WriteLine($"Stack destination {destination} after: ");

        foreach (string crate in crateStacks[destination])
        {
            Console.WriteLine(crate);
        }
        i++;
    }
}
Console.WriteLine("Final result");

foreach(var list in crateStacks)
{
    Console.Write(list.LastOrDefault());
}