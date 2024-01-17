// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// Программа должна выдать ответ: Да/ Нет

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

bool CheckNumInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}
System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input array maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);

PrintArray(array);
System.Console.WriteLine("Input element to find: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(CheckNumInArray(array, num));
