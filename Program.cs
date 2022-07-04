// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
string[] array1 = new string[6] {"1", "12", "123", "1234", "12345","123456"};
string[] array2 = new string[array1.Length];
void Result(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[index] = array1[i];
        index++;
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
Result(array1, array2);
PrintArray(array2);

