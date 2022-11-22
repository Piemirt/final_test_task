Console.Clear();

string[] firstArray = new string[4] { "hello", "2", "world", ":-)" };
string[] secondArray = new string[firstArray.Length];

ArrayCheck(firstArray, secondArray);
PrintArray(secondArray);


void ArrayCheck(string[] firstArray, string[] secondArray)
{
    int n = 3;
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= n)
        {
            secondArray[j] = firstArray[i];
            j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}