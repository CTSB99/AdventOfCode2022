using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

string[] InputArray = System.IO.File.ReadAllLines(@"C:\Users\christian.schulze\source\repos\AdventofCode\Day4\Day4\Day4\Input.txt");

int counter = 0;
int counter2 = 0;

foreach (var item in InputArray)
{
    int[] firstArray = new int[2];
    int[] secondArray = new int[2];

    string first = item.Split(",").First().ToString();
    string second = item.Substring(first.Length + 1, item.Length - first.Length - 1);

    firstArray[0] = Int32.Parse(first.Split("-").First());
    firstArray[1] = Int32.Parse(first.Substring(firstArray[0].ToString().Length + 1, first.Length - firstArray[0].ToString().Length - 1));
    secondArray[0] = Int32.Parse(second.Split("-").First());
    secondArray[1] = Int32.Parse(second.Substring(secondArray[0].ToString().Length + 1, second.Length - secondArray[0].ToString().Length - 1));

    //Console.WriteLine(item);

    //Console.WriteLine(firstArray[0]);
    //Console.WriteLine(firstArray[1]);
    //Console.WriteLine(secondArray[0]);
    //Console.WriteLine(secondArray[1] + "\n");

    if ((firstArray[0] <= secondArray[0] && firstArray[1] >= secondArray[1]) || (firstArray[0] >= secondArray[0] && firstArray[1] <= secondArray[1]))
    {
        counter++;
    }

    //Console.WriteLine(counter + "\n");

    // ############### Part 2 #####################

    if ((firstArray[1] >= secondArray[0] && firstArray[0] <= secondArray[0]) || (firstArray[0] <= secondArray[1] && firstArray[0] >= secondArray[0]))
    {
        counter2++;
    }
    else
    {
        Console.WriteLine(item);
        Console.WriteLine(counter2 + "\n");

    }

}

Console.WriteLine(counter2 + "\n");