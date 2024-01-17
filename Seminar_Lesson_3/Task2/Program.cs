// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// двигаемся к середине попарно
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    System.Console.WriteLine(array[0]);
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int[] PairsCount(int[] array)
{
    int[] tempArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length/2; i++)
    {
        tempArray[i] = array[i] * array[array.Length - i -1];
    }
    return tempArray;
}


System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input array maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);

PrintArray(array);
PrintArray(PairsCount(array));
// System.Console.WriteLine("Input element to find: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CheckNumInArray(array, num));
