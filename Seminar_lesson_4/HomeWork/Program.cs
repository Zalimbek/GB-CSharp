//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while(true)
// {
//     Console.WriteLine("Please enter an integer value or q to quit: ");
//     string input = Console.ReadLine(); 
//     if (input=="q")
//        {
//            break;
//        }
//     int number = 0;
//     if(Int32.TryParse(input, out number))
//     {  int sum = 0;
//         while (number > 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }
//     if (sum % 2 == 0)
//     {   
//         System.Console.WriteLine("The sum of digits is even!");
//         break;
//     }

//     }

// }

// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 999 + 1);
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
// int EvenNumbersCounter(int[] array)
// {
//     int count = 0;
//     for (int i  = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             {
//                 count++;
//             }
//         } return count;
//     }


// System.Console.WriteLine("Input array size: " );
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size);
// PrintArray(array);
// Console.WriteLine(EvenNumbersCounter(array)); 

// Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

using System.Globalization;
using System.Xml.XPath;

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

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
int[] ViceVersa(int[] array)
{ 
    int result = 0;
    for (int i  = 0; i < array.Length/2; i++)
    {   
        result = array[i];
        array[i] = array[array.Length-i-1];
        array[array.Length-i-1] = result;
    } 
    return array;
    }
    

System.Console.WriteLine("Input array size: " );
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] array = CreateRandomArray(size, min, max);
PrintArray(array);
int[] res = ViceVersa(array); 
PrintArray(res);