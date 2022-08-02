string[] Arr1 = new string[4] {"HELLO", "2","world", ":-)"};
string[] Arr2 = new string[Arr1.Length];
void SecondArrayWithIF(string[] Array1, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
    if(Arr1[i].Length <= 3)
        {
        Arr2[count] = Array1[i];
        count++;
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
SecondArrayWithIF(Arr1, Arr2);
PrintArray(Arr2);