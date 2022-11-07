string[] inputArray = { "Russia", "Denmark", "Kazan"};
int lengthToShow = 3;

void ArrayPrintOut(string[] input)
{
    Console.WriteLine("[" + string.Join(", ", input) + "]");
}

string[] ArraySorter(string[] input, int lengthToShow)
{
    List<string> sortedOut = new List<string>();
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length<=lengthToShow)
            sortedOut.Add(input[i]);
    }
    string[] sortedArray = new string[sortedOut.Count];
    for (int i = 0; i < sortedOut.Count; i++)
        sortedArray[i]=sortedOut[i];
    return sortedArray;
}

Console.WriteLine("unsorted: ");
ArrayPrintOut(inputArray);
string[] srtArray = ArraySorter(inputArray, lengthToShow);
Console.WriteLine("sorted: ");
ArrayPrintOut(srtArray);