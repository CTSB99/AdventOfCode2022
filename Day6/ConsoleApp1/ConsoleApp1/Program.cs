using System.Xml;

string input = System.IO.File.ReadAllText(@"../../../Input.txt");
int i = 0;
int k = 0;
char[] charArray = new char[14];
bool unique = false;

while (i < input.Length)
{
    while(k < 14)
    {
        charArray[k] = input[i + k];
        k++;
    }
    k = 0;
    unique = charArray.Distinct().Count() == 14;

    if (unique)
    {
        Console.WriteLine(i+14);
        break;
    }

    i++;
}