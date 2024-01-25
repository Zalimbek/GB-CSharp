// Задать массив чисел, заполнить рандомными числами и определить кол-во простых чисел

// using System.ComponentModel.DataAnnotations;

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// int SimpleNumCounter(int[] array)
// {
//     int count = 0;
//     for (int i  = 0; i < array.Length; i++)
//     {
//         if (array[i] != 1 && array[i] % 2!=0 || array[i] == 2)
//             if (array[i] % 3!=0 || array[i] == 3)
//                 if (array[i] % 5!=0 || array[i] == 5) 
//                     if (array[i] % 7!=0 || array[i] == 7)
//                         count++;
//         } return count;
//     }
    

// System.Console.WriteLine("Input array size: " );
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = {1,3, 4, 19, 3};
// //int[] array = CreateRandomArray(size, min, max);
// PrintArray(array);
// Console.WriteLine(SimpleNumCounter(array)); 

// Масив из n случайных чисел, найти кол-во чисел, которые оканчиваются на 1 и делятся нацело на 7


using System.ComponentModel.DataAnnotations;

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// int NumCounter(int[] array)
// {
//     int count = 0;
//     for (int i  = 0; i < array.Length; i++)
//     {
//         if (array[i] % 10 == 1 && array[i] % 7 == 0 )
//         count++;
//     } return count;
// }
    

// System.Console.WriteLine("Input array size: " );
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// // int[] array = {1,5, 11, 21, 81, 4, 0, 91, 2, 3};
// int[] array = CreateRandomArray(size, min, max);
// PrintArray(array);
// Console.WriteLine(NumCounter(array)); 

// Создать массив из цифр от 0 до 9 и составить число из цифр этого массива

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
// int ArrayToNum(int[] array)
// {
//     string str = string.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         str += array[i];
//     }
//    System.Console.WriteLine(str);
//    return Convert.ToInt32(str);
// }

// // 2 Method
// int ArrayToNum2(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = (int)(array[i] * Math.Pow(10, array.Length-i-1));
//         sum += array[i];
//     }
//       return sum;
// }
    

// System.Console.WriteLine("Input array size: " );
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// PrintArray(array);
// System.Console.WriteLine(ArrayToNum2(array));

// Дано целое число, посчитать кол-во цифр в числе

int DigitCounter(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num /= 10;
    } return count;
}
System.Console.WriteLine(DigitCounter(456));