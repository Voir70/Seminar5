/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний элемент и т.д.
Результат запишите в новой последовательности
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] GetArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 5);
    }
    return array;
}

/*int[] NewArray(int[] array)
{
    int[] arr;
    int len = 0;
    if (array.Length%2 == 0)
    {
        len = array.Length/2;
        arr = new int[len];
    }
    else
    {
        len = array.Length/2 + 1;
        arr = new int[len];
        arr[len-1] = array[len];
    }

    for (int i = 0; i < array.Length/2; i++)
    {
        arr[i] = array[i] * array[array.Length - i - 1];
    }
    return arr;
}*/

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
/*Console.WriteLine("Введите размер массива: ");
int[] array = GetArray(int.Parse(Console.ReadLine()));
PrintArray(array);
int[] arr = NewArray(array);
Console.WriteLine();
PrintArray(arr);*/

int[] NewArray(int[] arr)
{
    int len = 0;
    if (arr.Length % 2 == 0) len = arr.Length / 2;
    else len = arr.Length / 2 +1;

    int[]array = new int[len];
    //Console.WriteLine(len);
    for (int i = 0; i < len; i++)
    {
        array[i] = arr[i] * arr[arr.Length -1 -i];
        if (i == arr.Length -1 -i) array[i] = array[i] / arr[i];        
    }
    return array;
    }
Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine() ?? "");

int[] array = GetArray(length);
PrintArray(array);
Console.WriteLine();
int[] array1 = NewArray(array);
PrintArray(array1);
   