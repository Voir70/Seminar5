// See https://aka.ms/new-console-template for more information
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }

    return array;
}

//печатает массив на экран
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}    

    bool IsExist(int[]arr, int number)
    {
       for (int i = 0; i < arr.Length; i++)
       {
        if(arr[i] == number) return true;
       }
       return false; 
    }
int[] array = InitArray(5);
PrintArray(array);
  Console.WriteLine("Введите число: ");
  int num = Convert.ToInt32(Console.ReadLine() ?? "");
   Console.WriteLine(IsExist(array, num));