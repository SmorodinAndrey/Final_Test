string[] FilterArray(string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] outputArray = new string[count];
    int index = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
    }

    return outputArray;
}

Console.Write("Введите элементы массива, разделенные запятой: ");
string input = Console.ReadLine() ?? "";

string[] inputArray = input.Split(',');
string[] outputArray = FilterArray(inputArray);

Console.WriteLine("Результат:");
Console.Write("[");
foreach (string item in outputArray)
{
    Console.Write($"\"{item}\",");
}
Console.Write("]");
Console.WriteLine();
