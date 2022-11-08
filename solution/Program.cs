string[] inputArray = { "Russia", "Denmark", "Kazan" };
int lengthToShow = 3;

void ArrayPrintOut(string[] input)
{
    Console.WriteLine("[" + string.Join(", ", input) + "]");
}

string[] ArraySorter(string[] input, int lengthToShow)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= lengthToShow)
            count++;
    }
    int index = 0;
    string[] sortedArray = new string[count];
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= lengthToShow)
        {
            sortedArray[index] = input[i];
            index++;
        }
    }
    return sortedArray;
}

Console.WriteLine("unsorted: ");
ArrayPrintOut(inputArray);
string[] srtArray = ArraySorter(inputArray, lengthToShow);
Console.WriteLine("sorted: ");
ArrayPrintOut(srtArray);