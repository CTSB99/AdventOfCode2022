string opponentInput = "";

int counter = 0;
int score = 0;

string[][] matches = new string[2500][];

foreach (string line in System.IO.File.ReadLines(@"C:\Users\christian.schulze\source\repos\AdventofCode\Day2\Day2Puzzle1\Day2Puzzle1\Input.txt"))
{
    //switch (line[2].ToString())
    //{
    //    case "X": opponentInput = "A";break;
    //    case "Y": opponentInput = "B";break;
    //    case "Z": opponentInput = "C";break;
    //}
    matches[counter] = new string[] { line[0].ToString(), line[2].ToString() };
    counter++;
}

int GetResult(string[] match)
{
    if (match[0] != match[1])
    {
        switch (match[1])
        {
            case "A": return (match[0] == "C" ? 7 : 1);
            case "B": return (match[0] == "A" ? 8 : 2);
            case "C": return (match[0] == "B" ? 9 : 3);
        }
    }
    else
    {
        switch (match[1])
        {
            case "A": return 4;
            case "B": return 5;
            case "C": return 6;
        }
    }
        return 0;
}

// ################### Part 2 ###########################

int GetResult2(string[] match)
{
    int response = 0;

    switch (match[1])
    {
        case "X":
            switch (match[0])
            {
                case "A": response = 3; break;
                case "B": response = 1; break;
                case "C": response = 2; break;
            }
            break;

        case "Y":
            switch (match[0])
            {
                case "A": response = 4; break;
                case "B": response = 5; break;
                case "C": response = 6; break;
            }
            break;

        case "Z":
            switch (match[0])
            {
                case "A": response = 8; break;
                case "B": response = 9; break;
                case "C": response = 7; break;
            }
            break;
    }
    return response;
}

foreach (var Match in matches)
{
    Console.WriteLine($"{Match[0]} vs {Match[1]}");
    Console.WriteLine("Result: " + GetResult2(Match));

    score += GetResult2(Match);

    Console.WriteLine("Score: " + score);
}
Console.WriteLine("Score: " + score);