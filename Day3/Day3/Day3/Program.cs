using System.ComponentModel;
using System.Linq;
using System.Text;

string[] input = System.IO.File.ReadAllLines(@"C:\Users\christian.schulze\source\repos\AdventofCode\Day3\Day3\Day3\Input.txt");
char[] sameItem = new char[input.Length];
char[] sameBadge = new char[input.Length / 3];
char[] alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

int i = 0;
int k = 0;
int sum = 0;
int sumBadge = 0;

foreach (string item in input)
{
    i++;
    string compOne = "";
    string compTwo = "";

    compOne = item.Substring(0, item.Length / 2);
    compTwo = item.Substring(item.Length / 2, compOne.Length);

    //Console.WriteLine(i)
    //Console.WriteLine(item);
    //Console.WriteLine(compOne);
    //Console.WriteLine(compTwo + "\n");

    sameItem[i - 1] = compOne.Intersect(compTwo).First();
}

foreach (char item in sameItem)
{
    //Console.WriteLine(item);
    sum += Array.IndexOf(alphabet, item) + 1;
    //Console.WriteLine(sum);
}

Console.WriteLine("Sum: " + sum);

i = 0;

for (k = 0; k < input.Length; k+=3)
{
    Console.WriteLine(input[k]);
    Console.WriteLine(input[k+1]);
    Console.WriteLine(input[k+2]);

    var firstIntersect = input[k].Intersect(input[k+1]);
    var secondIntersect = firstIntersect.Intersect(input[k+2]).First();

    Console.WriteLine(secondIntersect);

    sameBadge[i] = secondIntersect;
    i++;
}

foreach (char item in sameBadge)
{
    Console.WriteLine(item);
    sumBadge += Array.IndexOf(alphabet, item) + 1;
    Console.WriteLine(sumBadge);
}