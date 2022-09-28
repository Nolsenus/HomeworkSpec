string[] ArrayOfLengthThree(string[] array)
{
    int count = 0;
    for ( int i = 0; i < array.Length; ++i)
    {
        if (array[i].Length < 4)
        {
            count++;
        }
    }
    string[] result = new string[count];
    if (count == 0)
    {
        return result;
    }
    int pos = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i].Length < 4)
        {
            result[pos] = array[i];
            pos++;
        }
    }
    return result;
}

void PrintStringArray(string[] array)
{
    int length = array.Length;
    if (length == 0)
    {
        return;
    }
    for (int i = 0; i < length - 1; ++i)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.WriteLine($"\"{array[length - 1]}\"");
}

Console.Write("Введите длину массива (целое число): ");
try
{
    int length = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[length];
    for (int i = 0; i < length; ++i) {
        Console.Write($"Введите элемент массива с индеском {i}: ");
        array[i] = Console.ReadLine();
    }
    Console.Write("Изначальный массив - ");
    PrintStringArray(array);
    Console.Write("Результирующий массив - ");
    PrintStringArray(ArrayOfLengthThree(array));
} catch (FormatException) {
    Console.WriteLine("Вы ввели не целое число.");
}