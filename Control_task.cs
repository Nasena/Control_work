using System.Globalization;

string[] array1 = new string[6] { "Hello", "1567", "-13", "world", "Kazan", ":-)" };
string[] array2 = new string[array1.Length];

void CreateArray2(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
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
CreateArray2(array1, array2);
PrintArray(array2);