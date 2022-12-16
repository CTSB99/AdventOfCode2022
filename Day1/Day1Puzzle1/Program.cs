// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using static System.Net.WebRequestMethods;
/*
int lines = 0;
string text = System.IO.File.ReadAllText("C:\\Users\\christian.schulze\\source\\repos\\AdventofCode\\Day1Puzzle1\\Day1Puzzle1\\Input.txt");

string text2 = System.IO.File.ReadLines("Input.txt");

foreach (string line in text) 
    Console.WriteLine(line);
*/


int counter = 0;
int sumCounter = 0;
long[] summs = new long[250];
int[] vals = new int[3000];

long[] GetSum()
{
    foreach (string line in System.IO.File.ReadLines(@"C:\\Users\\christian.schulze\\source\\repos\\AdventofCode\\Day1Puzzle1\\Day1Puzzle1\\Input.txt"))
    {
        if (line != "")
        {
            
            vals[counter] = int.Parse(line);
            counter++;
        }
        else
        {
            int i = 0;

            counter = 0;
            summs[sumCounter] = vals.Sum();
            sumCounter++;

            foreach (int element in vals)
            {
                vals[i] = 0;
                i++;
            }
        }
    }
    return summs;
}

summs = GetSum();

foreach (long sum in summs)
{
    Console.WriteLine(sum);
}

// OrderByDescending for Part 2
summs = summs.OrderByDescending(x => x).ToArray();

long largestSum = summs.Max();

Console.WriteLine($"Largest sum: {largestSum}");

// ################### Part 2 ########################

long sumOfLargest3Sums = summs[0] + summs[1] + summs[2];

Console.WriteLine($"Largest 3 summs: \n {summs[0]} \n {summs[1]} \n {summs[2]} \n Sum of 3 largest sums: {sumOfLargest3Sums}");